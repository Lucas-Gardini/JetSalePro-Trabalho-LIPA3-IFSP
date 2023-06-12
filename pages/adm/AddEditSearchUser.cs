using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.Properties;
using JetSalePro.services;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class AddEditSearchUser : KryptonForm {
        // Modal de carregamento
        Loading loadingForm = new Loading();

        public User CurrentUser = new User();

        private bool _isSearch = false;

        public AddEditSearchUser(string userId, bool isSearch) {
            InitializeComponent();

            CurrentUser.CodigoUsuario = int.Parse(userId);

            if (isSearch) {
                ButtonSave.Text = "✅ Buscar";
                TextBoxPassword.Hide();
                TextBoxCod.Enabled = true;
                TextBoxCod.ReadOnly = false;
            }

            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

            _isSearch = isSearch;
        }

        private void GoBack(object sender, EventArgs e) {
            this.Close();
        }

        private async void AddEditUser_Load(object sender, EventArgs e) {
            if (CurrentUser.CodigoUsuario == -1) return;

            var user = await User.GetUsers($"WHERE codigo_usuario = {CurrentUser.CodigoUsuario}");

            if (user != null) {
                TextBoxCod.Text = user.Rows[0]["codigo_usuario"].ToString();
                TextBoxName.Text = user.Rows[0]["nome"].ToString();
                TextBoxUsername.Text = user.Rows[0]["usuario"].ToString();
                TextBoxPassword.Text = "******";

                CheckboxActive.Checked = (bool)user.Rows[0]["situacao"];
                CheckBoxAdm.Checked = (bool)user.Rows[0]["adm"];
            } else {
                new Alert("Usuário", "Usuário não encontrado!").ShowDialog();
            }
        }

        private void SuccessIcon_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
            // Load the transparent image with an alpha channel
            Image image = Resources.success;

            // Set the image's background color to transparent
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorKey(Color.Transparent, Color.Transparent);

            // Draw the image on the control's surface with alpha blending
            e.Graphics.DrawImage(
                image,
                new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height),
                0,
                0,
                image.Width,
                image.Height,
                GraphicsUnit.Pixel,
                imageAttributes
            );
        }

        private async void ButtonSave_Click(object sender, EventArgs e) {
            loadingForm.Show();
            loadingForm.Refresh();

            if (!TextBoxPassword.Text.StartsWith("**")) {
                CurrentUser.Senha = TextBoxPassword.Text;
            }

            try {
                CurrentUser.CodigoUsuario = int.Parse(TextBoxCod?.Text);
            } catch { }

            CurrentUser.Nome = TextBoxName.Text;
            CurrentUser.Usuario = TextBoxUsername.Text;
            CurrentUser.Situacao = CheckboxActive.Checked;
            CurrentUser.Adm = CheckBoxAdm.Checked;

            if (_isSearch) {
                loadingForm.Close();
                DialogResult dialogResult = DialogResult.OK;
                this.DialogResult = dialogResult;
                this.Close();
                return;
            };

            bool sucesso;
            if (CurrentUser.CodigoUsuario == -1) {
                sucesso = await User.CreateUser(CurrentUser);
            } else {
                sucesso = await User.UpdateUser(CurrentUser, CurrentUser.Senha != null);
            }

            loadingForm.Close();

            if (sucesso) {
                new Success("Usuário", "Usuário salvo com sucesso!").ShowDialog();

                this.Close();
            } else {
                new Alert("Usuário", "Erro ao salvar usuário!").ShowDialog();
            }
        }
    }
}
