using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.services;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class Client : KryptonForm {
        // Modal de carregamento
        Loading loadingForm;

        private bool _loaded = false;

        public Client() {
            InitializeComponent();
        }

        private async Task AtLoad(object sender, Clients toSearch = null) {
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
                if (toSearch.CodigoClient != -1) {
                    where += $" codigo_cliente = {toSearch.CodigoClient} AND";
                }

                if (!string.IsNullOrEmpty(toSearch.Nome)) {
                    where += $" nome LIKE '%{toSearch.Nome}%' AND";
                }

                where += $" situacao = {(toSearch.Situacao ? 1 : 0)} AND";

                if (!string.IsNullOrEmpty(toSearch.CPF)) {
                    where += $" cpf LIKE '%{toSearch.CPF}%' AND";
                }

                if (!string.IsNullOrEmpty(toSearch.RG)) {
                    where += $" rg LIKE '%{toSearch.RG}%' AND";
                }

                if (!string.IsNullOrEmpty(toSearch.Genero)) {
                    where += $" genero LIKE '%{toSearch.Genero}%' AND";
                }

                if (toSearch.DataNasc != null) {
                    where += $" data_nascimento = '{toSearch.DataNasc}' AND";
                }

                if (!string.IsNullOrEmpty(toSearch.EstadoCivil)) {
                    where += $" estado_civil LIKE '%{toSearch.EstadoCivil}%' AND";
                }

                if (!string.IsNullOrEmpty(toSearch.Profissao)) {
                    where += $" profissao LIKE '%{toSearch.Profissao}%' AND";
                }

                if (!string.IsNullOrEmpty(toSearch.Nacionalidade)) {
                    where += $" nacionalidade LIKE '%{toSearch.Nacionalidade}%' AND";
                }

                if (toSearch.Telefone != -1) {
                    where += $" telefone = {toSearch.Telefone} AND";
                }

                if (toSearch.Celular != -1) {
                    where += $" celular = {toSearch.Celular} AND";
                }

                where += $" whatsapp = {(toSearch.Whatsapp ? 1 : 0)} AND";

                if (!string.IsNullOrEmpty(toSearch.Email)) {
                    where += $" email LIKE '%{toSearch.Email}%' AND";
                }

                if (!string.IsNullOrEmpty(toSearch.Obs)) {
                    where += $" obs LIKE '%{toSearch.Obs}%' AND";
                }

                if (!string.IsNullOrEmpty(toSearch.Rua)) {
                    where += $" rua LIKE '%{toSearch.Rua}%' AND";
                }

                if (toSearch.Numero != -1) {
                    where += $" numero = {toSearch.Numero} AND";
                }

                if (!string.IsNullOrEmpty(toSearch.Complemento)) {
                    where += $" complemento LIKE '%{toSearch.Complemento}%' AND";
                }

                if (!string.IsNullOrEmpty(toSearch.Bairro)) {
                    where += $" bairro LIKE '%{toSearch.Bairro}%' AND";
                }

                if (!string.IsNullOrEmpty(toSearch.Cidade)) {
                    where += $" cidade LIKE '%{toSearch.Cidade}%' AND";
                }

                if (!string.IsNullOrEmpty(toSearch.Uf)) {
                    where += $" uf LIKE '%{toSearch.Uf}%' AND";
                }

                if (toSearch.CEP != -1) {
                    where += $" cep = {toSearch.CEP} AND";
                }

                if (where.Length > 0) {
                    where = "WHERE " + where.TrimEnd("AND".ToCharArray());
                }
            }

            // Obtendo os usuários
            var data = await Clients.GetClients(where);

            DataGridViewClients.Rows.Clear();
            // LoopORo pelo resultado e adicionar os itens na row
            foreach (DataRow row in data.Rows) {
                DataGridViewClients.Rows.Add(row.ItemArray);
            }

            loadingForm.Close();
            _loaded = true;
        }

        private async void Form_Load(object sender, EventArgs e) {
            await AtLoad(sender);
        }

        private void GoBack(object sender, EventArgs e) {
            this.Close();
            new Thread(() => Application.Run(new Dashboard())).Start();
        }

        private void PictureAdd_Click(object sender, EventArgs e) {
            new AddEditSearchClient("-1", false).ShowDialog();

            Form_Load(sender, e);
        }

        private void UserManagement_Resize(object sender, EventArgs e) {
            if (_loaded)
                Global.FormResize(this);
        }

        private async void PictureSearch_Click(object sender, EventArgs e) {
            AddEditSearchClient dialog = new AddEditSearchClient("-1", true);
            DialogResult toSearch = dialog.ShowDialog();

            if (toSearch == DialogResult.OK) {
                await AtLoad(sender, dialog.CurrentClient);
            }
        }

        private async void PictureDelete_Click(object sender, EventArgs e) {
            var id = DataGridViewClients.SelectedCells[0].Value.ToString();
            var cliente = DataGridViewClients.SelectedCells[1].Value.ToString();

            Alert dialog = new Alert("Excluir cliente", $"Deseja realmente excluir o(a) {cliente}?", true);
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                loadingForm = new Loading();

                loadingForm.Show();

                var success = await Clients.DeleteClient(id);

                loadingForm.Close();

                if (success) {
                    new Success("Sucesso!", "Cliente excluído com sucesso.").ShowDialog();
                    Form_Load(sender, e);
                } else {
                    new Alert("Erro!", "Não foi possível excluir o cliente.").ShowDialog();
                }

            }
        }

        private void PictureEdit_Click(object sender, EventArgs e) {
            if (DataGridViewClients.SelectedCells.Count == 0) {
                new Alert("Ação Inválida!", "Selecione um cliente para editar.").ShowDialog();
                return;
            }

            var id = DataGridViewClients.SelectedCells[0].Value.ToString();
            new AddEditSearchClient(id, false).ShowDialog();

            Form_Load(sender, e);
        }

        private void PictureReset_Click(object sender, EventArgs e) {
            Form_Load(sender, e);
        }
    }
}
