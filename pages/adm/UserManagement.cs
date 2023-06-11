using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.services;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class UserManagement : KryptonForm {
        // Modal de carregamento
        Loading loadingForm;

        private bool _loaded = false;

        public UserManagement() {
            InitializeComponent();
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
            var data = await User.GetUsers();

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
            new AddEditUser("-1").ShowDialog();

            Form_Load(sender, e);
        }

        private void UserManagement_Resize(object sender, EventArgs e) {
            if (_loaded)
                Global.FormResize(this);
        }

        private void PictureSearch_Click(object sender, EventArgs e) {

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

                var success = await User.DeleteUser(id);

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
            new AddEditUser(id).ShowDialog();

            Form_Load(sender, e);

        }
    }
}
