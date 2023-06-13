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

			DataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            new AddEditProduct("-1").ShowDialog();

            Form_Load(sender, e);
        }

        private void UserManagement_Resize(object sender, EventArgs e) {
            if (_loaded)
                Global.FormResize(this);
        }

        private void PictureSearch_Click(object sender, EventArgs e) {

        }

        private async void PictureDelete_Click(object sender, EventArgs e) {
            var id = DataGridViewProducts.SelectedCells[0].Value.ToString();
            var produto = DataGridViewProducts.SelectedCells[1].Value.ToString();

            Alert dialog = new Alert("Excluir produto", $"Deseja realmente excluir o {produto}?", true);
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
            new AddEditProduct(id).ShowDialog();

            Form_Load(sender, e);
        }
    }
}
