using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using System;
using System.Threading;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class Dashboard : KryptonForm {
        // Modal de carregamento
        Loading loadingForm = new Loading();
        private bool _loaded = false;

        public Dashboard() {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e) {
            if (Global.FormSize.Width != 0) {
                this.Size = Global.FormSize;
            }

            if (Global.FormMaximized) {
                this.WindowState = FormWindowState.Maximized;
            }

            this.Activate();

            Global.FormResize(this);

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

            _loaded = true;
        }

        private void ButtonLiberacaoUsers_Click(object sender, EventArgs e) {
            this.Close();
            new Thread(() => Application.Run(new UserManagement())).Start();
        }

        private void Dashboard_Resize(object sender, EventArgs e) {
            if (_loaded)
                Global.FormResize(this);
        }

		private void ButtonProdutos_Click(object sender, EventArgs e)
		{
			this.Close();
			new Thread(() => Application.Run(new Product())).Start();
		}

		private void ButtonClientes_Click(object sender, EventArgs e)
		{
			this.Close();
			new Thread(() => Application.Run(new Client())).Start();
		}
	}
}
