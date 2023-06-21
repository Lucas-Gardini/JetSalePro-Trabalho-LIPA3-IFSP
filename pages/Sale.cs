using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.services;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class Sale : KryptonForm {
        // Modal de carregamento
        Loading loadingForm;

        private bool _loaded = false;

        public Sale() {
            InitializeComponent();
        }

        private async Task AtLoad(object sender, Sales toSearch = null) {
            this.Size = Global.FormSize;

            if (Global.FormMaximized) {
                this.WindowState = FormWindowState.Maximized;
            }

            loadingForm = new Loading();

            //if (!Global.Adm) {
            //    GoBack(sender, EventArgs.Empty);
            //    return;
            //}

            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

            loadingForm.Show();

            var where = "";

            if (toSearch != null) {
                //if (toSearch.CodigoClient != -1) {
                //    where += $" codigo_cliente = {toSearch.CodigoClient} AND";
                //}
            }

            // Obtendo os usuários
            var data = await Sales.GetSales(where);

            DataGridViewSales.Rows.Clear();
            // LoopORo pelo resultado e adicionar os itens na row
            foreach (DataRow row in data.Rows) {
                DataGridViewSales.Rows.Add(row.ItemArray);
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
            new AddEditSearchSales("-1", false).ShowDialog();

            Form_Load(sender, e);
        }

        private void UserManagement_Resize(object sender, EventArgs e) {
            if (_loaded)
                Global.FormResize(this);
        }

        private async void PictureSearch_Click(object sender, EventArgs e) {
            AddEditSearchSales dialog = new AddEditSearchSales("-1", true);
            DialogResult toSearch = dialog.ShowDialog();

            if (toSearch == DialogResult.OK) {
                await AtLoad(sender, dialog.CurrentSale);
            }
        }

        private async void PictureDelete_Click(object sender, EventArgs e) {
            var id = DataGridViewSales.SelectedCells[0].Value.ToString();

            Alert dialog = new Alert("Excluir venda", $"Deseja realmente excluir a venda {id}?", true);
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                loadingForm = new Loading();

                loadingForm.Show();

                var success = await Sales.DeleteSale(id);

                loadingForm.Close();

                if (success) {
                    new Success("Sucesso!", "Venda excluída com sucesso.").ShowDialog();
                    Form_Load(sender, e);
                } else {
                    new Alert("Erro!", "Não foi possível excluir a venda.").ShowDialog();
                }

            }
        }

        private void PictureEdit_Click(object sender, EventArgs e) {
            if (DataGridViewSales.SelectedCells.Count == 0) {
                new Alert("Ação Inválida!", "Selecione um cliente para editar.").ShowDialog();
                return;
            }

            var id = DataGridViewSales.SelectedCells[0].Value.ToString();
            new AddEditSearchSales(id, false).ShowDialog();

            Form_Load(sender, e);
        }

        private void PictureReset_Click(object sender, EventArgs e) {
            Form_Load(sender, e);
        }
    }
}
