using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.services;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class Product : KryptonForm {
        // Modal de carregamento
        Loading loadingForm;

        private bool _loaded = false;

        public Product() {
            InitializeComponent();
        }

        private async void AtLoad(object sender, Products toSearch = null) {
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

                if (toSearch.CodigoProduto != -1) {
                    if (where.Length > 7) where += " AND";
                    where += $" codigo_produto = {toSearch.CodigoProduto}";
                }

                if (!string.IsNullOrEmpty(toSearch.Descricao)) {
                    if (where.Length > 7) where += " AND";
                    where += $" descricao LIKE '%{toSearch.Descricao}%'";
                }

                if (!string.IsNullOrEmpty(toSearch.CodigoBarras)) {
                    if (where.Length > 7) where += " AND";
                    where += $" codigo_barras LIKE '%{toSearch.CodigoBarras}%'";
                }

                if (!string.IsNullOrEmpty(toSearch.Marca)) {
                    if (where.Length > 7) where += " AND";
                    where += $" marca LIKE '%{toSearch.Marca}%'";
                }

                if (toSearch.Peso != -1) {
                    if (where.Length > 7) where += " AND";
                    where += $" peso = {toSearch.Peso}";
                }

                if (toSearch.Largura != -1) {
                    if (where.Length > 7) where += " AND";
                    where += $" largura = {toSearch.Largura}";
                }

                if (toSearch.Altura != -1) {
                    if (where.Length > 7) where += " AND";
                    where += $" altura = {toSearch.Altura}";
                }

                if (toSearch.Profundidade != -1) {
                    if (where.Length > 7) where += " AND";
                    where += $" profundidade = {toSearch.Profundidade}";
                }

                if (where.Length > 7) where += " AND";
                where += $" situacao = {toSearch.Situacao}";

                if (!string.IsNullOrEmpty(toSearch.Condicao)) {
                    if (where.Length > 7) where += " AND";
                    where += $" condicao LIKE '%{toSearch.Condicao}%'";
                }

                if (toSearch.PrecoVenda != -1) {
                    if (where.Length > 7) where += " AND";
                    where += $" preco_venda = {toSearch.PrecoVenda}";
                }

                if (toSearch.Quantidade != -1) {
                    if (where.Length > 7) where += " AND";
                    where += $" quantidade = {toSearch.Quantidade}";
                }

                if (toSearch.CodigoProduto == -1 && string.IsNullOrEmpty(toSearch.Descricao) && string.IsNullOrEmpty(toSearch.CodigoBarras) && string.IsNullOrEmpty(toSearch.Marca) && toSearch.Peso == -1 && toSearch.Largura == -1 && toSearch.Altura == -1 && toSearch.Profundidade == -1 && !toSearch.Situacao && string.IsNullOrEmpty(toSearch.Condicao) && toSearch.PrecoVenda == -1 && toSearch.Quantidade == -1) {
                    where = "";
                }

                // Removendo AND do final, caso a string termine em AND
                if (where.EndsWith("AND")) {
                    where = where.Substring(0, where.Length - 3);
                }
            }

            // Obtendo os produtos
            var data = await Products.GetProducts(where);

            DataGridViewProducts.Rows.Clear();
            // Loopando pelo resultado e adicionando os itens na row
            foreach (DataRow row in data.Rows) {
                DataGridViewProducts.Rows.Add(row.ItemArray);
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
            var data = await Products.GetProducts();

            DataGridViewProducts.Rows.Clear();
            // Loopando pelo resultado e adicionando os itens na row
            foreach (DataRow row in data.Rows) {
                DataGridViewProducts.Rows.Add(row.ItemArray);
            }

            loadingForm.Close();
            _loaded = true;
        }

        private void GoBack(object sender, EventArgs e) {
            this.Close();
            new Thread(() => Application.Run(new Dashboard())).Start();
        }

        private void PictureAdd_Click(object sender, EventArgs e) {
            new AddEditSearchProduct("-1").ShowDialog();

            Form_Load(sender, e);
        }

        private void UserManagement_Resize(object sender, EventArgs e) {
            if (_loaded)
                Global.FormResize(this);
        }

        private void PictureSearch_Click(object sender, EventArgs e) {
            AddEditSearchProduct dialog = new AddEditSearchProduct("-1", true);
            DialogResult toSearch = dialog.ShowDialog();

            if (toSearch == DialogResult.OK) {
                AtLoad(sender, dialog.CurrentProduct);
            }
        }

        private async void PictureDelete_Click(object sender, EventArgs e) {
            var id = DataGridViewProducts.SelectedCells[0].Value.ToString();
            var produto = DataGridViewProducts.SelectedCells[1].Value.ToString();

            Alert dialog = new Alert("Excluir produto", $"Deseja realmente excluir {produto}?", true);
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                loadingForm = new Loading();

                loadingForm.Show();

                var success = await Products.DeleteProduct(id);

                loadingForm.Close();

                if (success) {
                    new Success("Sucesso!", "Produto excluído com sucesso.").ShowDialog();
                    Form_Load(sender, e);
                } else {
                    new Alert("Erro!", "Não foi possível excluir o produto.").ShowDialog();
                }

            }
        }

        private void PictureEdit_Click(object sender, EventArgs e) {
            if (DataGridViewProducts.SelectedCells.Count == 0) {
                new Alert("Ação Inválida!", "Selecione um produto para editar.").ShowDialog();
                return;
            }

            var id = DataGridViewProducts.SelectedCells[0].Value.ToString();
            new AddEditSearchProduct(id).ShowDialog();

            Form_Load(sender, e);
        }

        private void PictureReset_Click(object sender, EventArgs e) {
            Form_Load(sender, e);
        }
    }
}
