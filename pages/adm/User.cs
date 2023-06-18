using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class User : KryptonForm {
        // Modal de carregamento
        Loading loadingForm;

        private bool _loaded = false;

        public User() {
            InitializeComponent();

            DataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void AtLoad(object sender, services.User toSearch = null) {
            this.Size = Global.FormSize;

            if (Global.FormMaximized) {
                this.WindowState = FormWindowState.Maximized;
            }

            loadingForm = new Loading();

            if (!Global.Adm) {
                GoBack(sender, EventArgs.Empty);
                return;
            }

            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

            loadingForm.Show();

            var where = "";

            if (toSearch != null) {
                where = "WHERE ";

                if (toSearch.Usuario != null && toSearch.Usuario != "") {
                    if (where.Length > 7) where += " AND";
                    where += $" usuario LIKE '%{toSearch.Usuario}%'";
                }

                if (toSearch.Nome != null && toSearch.Nome != "") {
                    if (where.Length > 7) where += " AND";
                    where += $" nome LIKE '%{toSearch.Nome}%'";
                }

                if (toSearch.CodigoUsuario != -1 && toSearch.CodigoUsuario.ToString() != "") {
                    if (where.Length > 7) where += " AND";
                    where += $" codigo_usuario = {toSearch.CodigoUsuario}";
                }

                if (where.Length > 7) where += " AND";
                else where += $" situacao = {toSearch.Situacao}";

                if (where.Length > 7) where += " AND";
                else where += $" adm = {toSearch.Adm}";

                if (toSearch.CodigoUsuario == -1 && toSearch.Usuario == null && toSearch.Nome == null && toSearch.Situacao == false && toSearch.Adm == false) {
                    where = "";
                }

                // Removendo AND do final, caso a string termine em AND
                if (where.EndsWith("AND")) {
                    where = where.Substring(0, where.Length - 3);
                }
            }

            // Obtendo os usuários
            var data = await services.User.GetUsers(where);

            DataGridViewUsers.Rows.Clear();
            // Loopando pelo resultado e adicionando os itens na row
            foreach (DataRow row in data.Rows) {
                DataGridViewUsers.Rows.Add(row.ItemArray);
            }

            loadingForm.Close();
            _loaded = true;
        }

        private async void Form_Load(object sender, EventArgs e) {
            this.Size = Global.FormSize;

            if (Global.FormMaximized) {
                this.WindowState = FormWindowState.Maximized;
            }

            loadingForm = new Loading();

            if (!Global.Adm) {
                GoBack(sender, EventArgs.Empty);
                return;
            }

            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

            loadingForm.Show();

            // Obtendo os usuários
            var data = await services.User.GetUsers();

            DataGridViewUsers.Rows.Clear();
            // Loopando pelo resultado e adicionando os itens na row
            foreach (DataRow row in data.Rows) {
                DataGridViewUsers.Rows.Add(row.ItemArray);
            }

            loadingForm.Close();
            _loaded = true;
        }

        private void GoBack(object sender, EventArgs e) {
            this.Close();
            new Thread(() => Application.Run(new Dashboard())).Start();
        }

        private void PictureAdd_Click(object sender, EventArgs e) {
            new AddEditSearchUser("-1", false).ShowDialog();

            Form_Load(sender, e);
        }

        private void UserManagement_Resize(object sender, EventArgs e) {
            if (_loaded)
                Global.FormResize(this);
        }

        private void PictureSearch_Click(object sender, EventArgs e) {
            AddEditSearchUser dialog = new AddEditSearchUser("-1", true);
            DialogResult toSearch = dialog.ShowDialog();

            if (toSearch == DialogResult.OK) {
                AtLoad(sender, dialog.CurrentUser);
            }
        }

        private async void PictureDelete_Click(object sender, EventArgs e) {
            var id = DataGridViewUsers.SelectedCells[0].Value.ToString();
            var username = DataGridViewUsers.SelectedCells[2].Value.ToString();

            if (username == Global.CurrentUser) {
                new Alert("Ação Inválida!", "Você não pode excluir o usuário que está logado.").ShowDialog();
                return;
            }

            Alert dialog = new Alert("Excluir usuário", $"Deseja realmente excluir o usuário {username}?", true);
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                loadingForm = new Loading();

                loadingForm.Show();

                var success = await services.User.DeleteUser(id);

                loadingForm.Close();

                if (success) {
                    new Success("Sucesso!", "Usuário excluído com sucesso.").ShowDialog();
                    Form_Load(sender, e);
                } else {
                    new Alert("Erro!", "Não foi possível excluir o usuário.").ShowDialog();
                }

            }
        }

        private void PictureEdit_Click(object sender, EventArgs e) {
            if (DataGridViewUsers.SelectedCells.Count == 0) {
                new Alert("Ação Inválida!", "Selecione um usuário para editar.").ShowDialog();
                return;
            }

            var id = DataGridViewUsers.SelectedCells[0].Value.ToString();
            new AddEditSearchUser(id, false).ShowDialog();

            Form_Load(sender, e);
        }

        private void PictureReset_Click(object sender, EventArgs e) {
            Form_Load(sender, e);
        }
    }
}
