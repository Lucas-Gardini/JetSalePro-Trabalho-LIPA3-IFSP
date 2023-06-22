using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.services;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class Report : KryptonForm {
        // Modal de carregamento
        Loading loadingForm;

        private bool _loaded = false;

        public Report() {
            InitializeComponent();
        }

        private async Task AtLoad(object sender, Clients toSearch = null) {
            this.Size = Global.FormSize;

            if (Global.FormMaximized) {
                this.WindowState = FormWindowState.Maximized;
            }

            loadingForm = new Loading();
			loadingForm.Show();

			//if (!Global.Adm) {
			//    GoBack(sender, EventArgs.Empty);
			//    return;
			//}

			LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

			DataGridViewProductsMoreSale.Rows.Clear();
			LabelQuantVendas.Text = "";
			LabelValorVendas.Text = "";

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

		private async void ButtonSearch_Click(object sender, EventArgs e)
		{
			loadingForm = new Loading();
			loadingForm.Show();

			DateTime dataIni = DatePickerInic.Value;
			DateTime dataFim = DatePickerFim.Value;

			string strDataIni = dataIni.ToString("yyyy-MM-dd");
			string strDataFim = dataFim.ToString("yyyy-MM-dd");

			var where = $"v.data_venda BETWEEN '{strDataIni}' AND '{strDataFim}'";

			// Obtendo os 10 produtos mais vendidos
			var data = await Products.GetProductsMoreSale(where);

			DataGridViewProductsMoreSale.Rows.Clear();
			// Loop pelo resultado e adicionar os itens na row
			foreach (DataRow row in data.Rows)
			{
				DataGridViewProductsMoreSale.Rows.Add(row.ItemArray);
			}

			// Obtendo total de vendas em determinado período
			int salesCount = await SalesTotals.GetSalesCount(where);
			LabelQuantVendas.Text = salesCount.ToString();

			// Obtendo o valor total das vendas em determinado período
			float salesSum = await SalesTotals.GetSalesSum(where);
			LabelValorVendas.Text = salesSum.ToString();

			loadingForm.Close();
		}

		private void UserManagement_Resize(object sender, EventArgs e) {
            if (_loaded)
                Global.FormResize(this);
        }

		private void PictureAdd_Click(object sender, EventArgs e) {
        }

        private async void PictureSearch_Click(object sender, EventArgs e) {
        }

        private async void PictureDelete_Click(object sender, EventArgs e) {
        }

        private void PictureEdit_Click(object sender, EventArgs e) {
        }

        private void PictureReset_Click(object sender, EventArgs e) {
            Form_Load(sender, e);
        }
	}
}
