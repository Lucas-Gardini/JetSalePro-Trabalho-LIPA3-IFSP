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

        public UserManagement() {
            InitializeComponent();
        }

        private async void Form_Load(object sender, EventArgs e) {
            loadingForm = new Loading();

            if (!Global.Adm) {
                GoBack(sender, EventArgs.Empty);
                return;
            }

            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

            loadingForm.Show();

            // Obtendo os usuários
            var data = await User.GetUsers();

            // Loopando pelo resultado e adicionando os itens na row
            foreach (DataRow row in data.Rows) {
                DataGridViewUsers.Rows.Add(row.ItemArray);
            }

            loadingForm.Close();
        }

        private void GoBack(object sender, EventArgs e) {
            this.Close();
            new Thread(() => Application.Run(new Dashboard())).Start();
        }

        private void PictureAdd_Click(object sender, EventArgs e) {
            new AddEditUser("-1").ShowDialog();

            Form_Load(sender, e);
        }
    }
}
