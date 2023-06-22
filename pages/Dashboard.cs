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

        private async void Dashboard_Load(object sender, EventArgs e) {
            if (Global.Adm) {
                pictureBox1.Image = Properties.Resources.Dash_Adm1;
            }

            var loadingForm = new Loading();
            loadingForm.Show();

            LabelUser.Hide();
            LabelLogout.Hide();
            LabelSell.Hide();
            LabelReports.Hide();
            LabelProducts.Hide();
            LabelAccessCrontrol.Hide();
            LabelClients.Hide();

            if (Global.FormSize.Width != 0) {
                this.Size = Global.FormSize;
            }

            if (Global.FormMaximized) {
                this.WindowState = FormWindowState.Maximized;
            }

            this.Hide();

            Global.FormResize(this);

            var username = await services.User.GetUsername(Global.CurrentUser);

            LabelUser.Text = LabelUser.Text.Replace("USUARIO", username);
            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

            if (Global.Adm == false) {
                //ButtonClients.Visible = false;
                //ButtonClients.Enabled = false;

                ButtonProducts.Visible = false;
                ButtonProducts.Enabled = false;

                ButtonUsers.Visible = false;
                ButtonUsers.Enabled = false;
            }

            _loaded = true;

            loadingForm.Close();

            this.Show();
            this.Activate();

            LabelUser.Show();
        }

        private void ButtonLiberacaoUsers_Click(object sender, EventArgs e) {
            this.Close();
            new Thread(() => Application.Run(new User())).Start();
        }

        private void Dashboard_Resize(object sender, EventArgs e) {
            if (_loaded)
                Global.FormResize(this);
        }

        private void ButtonProdutos_Click(object sender, EventArgs e) {
            this.Close();
            new Thread(() => Application.Run(new Product())).Start();
        }

        private void ButtonClientes_Click(object sender, EventArgs e) {
            this.Close();
            new Thread(() => Application.Run(new Client())).Start();
        }

        private void ButtonSales_Click(object sender, EventArgs e) {
            this.Close();
            new Thread(() => Application.Run(new Sale())).Start();
        }

		private void ButtonReports_Click(object sender, EventArgs e)
		{
			this.Close();
			new Thread(() => Application.Run(new Report())).Start();
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

        private void PictureLogout_MouseEnter(object sender, EventArgs e) {
            LabelLogout.Show();
        }

        private void PictureLogout_MouseLeave(object sender, EventArgs e) {
            LabelLogout.Hide();
        }

        private void ButtonSales_MouseEnter(object sender, EventArgs e) {
            LabelSell.Show();
        }

        private void ButtonSales_MouseLeave(object sender, EventArgs e) {
            LabelSell.Hide();
        }

        private void ButtonReports_MouseEnter(object sender, EventArgs e) {
            LabelReports.Show();
        }

        private void ButtonReports_MouseLeave(object sender, EventArgs e) {
            LabelReports.Hide();
        }

        private void ButtonProducts_MouseEnter(object sender, EventArgs e) {
            LabelProducts.Show();
        }

        private void ButtonProducts_MouseLeave(object sender, EventArgs e) {
            LabelProducts.Hide();
        }

        private void ButtonUsers_MouseEnter(object sender, EventArgs e) {
            LabelAccessCrontrol.Show();
        }

        private void ButtonUsers_MouseLeave(object sender, EventArgs e) {
            LabelAccessCrontrol.Hide();
        }

        private void ButtonClients_MouseEnter(object sender, EventArgs e) {
            LabelClients.Show();
        }

        private void ButtonClients_MouseLeave(object sender, EventArgs e) {
            LabelClients.Hide();
        }
	}
}
