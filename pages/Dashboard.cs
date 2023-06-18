using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using System;
using System.IO;
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
                ButtonClients.Visible = false;
                ButtonClients.Enabled = false;

                ButtonProducts.Visible = false;
                ButtonProducts.Enabled = false;

                ButtonUsers.Visible = false;
                ButtonUsers.Enabled = false;
            }

            _loaded = true;
        }

        private void ButtonLiberacaoUsers_Click(object sender, EventArgs e) {
            this.Close();
            new Thread(() => Application.Run(new User())).Start();
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

        private void Logout() {
            Global.CurrentUser = null;
            Global.Adm = false;

            if (File.Exists(Application.StartupPath + "/secret.txt")) {
                File.Delete(Application.StartupPath + "/secret.txt");
            }

            this.Close();
            new Thread(() => Application.Run(new Auth())).Start();
        }

        private void PictureLogout_Click(object sender, EventArgs e) {
            Logout();
        }

        private void LabelLogout_Click(object sender, EventArgs e) {
            Logout();
        }
    }
}
