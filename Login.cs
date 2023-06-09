using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class Login : KryptonForm {
        public Login() {
            InitializeComponent();
        }

        private void Login_Load(object sender, System.EventArgs e) {
            ButtonLogin.Cursor = Cursors.Hand;
            ButtonRegister.Cursor = Cursors.Hand;

            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";
        }

        private void TextBoxPassword_TextChanged(object sender, System.EventArgs e) {
            if (TextBoxPassword.Text.Length > 0)
                TextBoxPassword.PasswordChar = '*';
            else
                TextBoxPassword.PasswordChar = '\0';
        }

        private void TextBoxUser_Enter(object sender, System.EventArgs e) {
            if (TextBoxUser.Text == "Usuário") {
                TextBoxUser.Text = string.Empty;
            }
        }

        private void TextBoxUser_Leave(object sender, System.EventArgs e) {
            if (TextBoxUser.Text == string.Empty) {
                TextBoxUser.Text = "Usuário";
            }
        }

        private void TextBoxPassword_Enter(object sender, System.EventArgs e) {
            if (TextBoxPassword.Text == "Senha") {
                TextBoxPassword.Text = string.Empty;
            }
        }

        private void TextBoxPassword_Leave(object sender, System.EventArgs e) {
            if (TextBoxPassword.Text == string.Empty) {
                TextBoxPassword.Text = "Senha";
                TextBoxPassword.PasswordChar = '\0';
            }
        }

        private void Login_SizeChanged(object sender, System.EventArgs e) {
            if (this.Size.Width < 921) {
                PictureLogin.Hide();
            } else {
                PictureLogin.Show();
            }
        }
    }
}
