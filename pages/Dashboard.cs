using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using System;

namespace JetSalePro {
    public partial class Dashboard : KryptonForm {
        // Modal de carregamento
        Loading loadingForm = new Loading();

        public Dashboard() {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e) {
            LabelUser.Text = LabelUser.Text.Replace("USUARIO", Global.CurrentUser);
            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

			if (Global.Adm == false) {
				ButtonClientes.Visible = false;
				ButtonClientes.Enabled = false;

				ButtonProdutos.Visible = false;
				ButtonProdutos.Enabled = false;

				ButtonLiberacaoUsers.Visible = false;
				ButtonLiberacaoUsers.Enabled = false;
			}
        }
    }
}
