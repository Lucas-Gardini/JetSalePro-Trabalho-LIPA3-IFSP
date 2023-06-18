using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.Properties;
using JetSalePro.services;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class AddEditSearchClient : KryptonForm {
        // Modal de carregamento
        Loading loadingForm = new Loading();

        public Clients CurrentClient = new Clients();

        private bool _isSearch = false;

        public AddEditSearchClient(string clienteId, bool isSearch) {
            InitializeComponent();

            CurrentClient.CodigoClient = int.Parse(clienteId);

            if (isSearch) {
                ButtonSave.Image = Resources.search_full;
                TextBoxCod.Enabled = true;
                TextBoxCod.ReadOnly = false;

                TextBoxCod.StateCommon.Back.Color1 = Color.LightGray;

                // Desabilitando campos numéricos (complicações no desenvolvimento e sem tempo de consertar)
                DatePicker.Enabled = false;

                DatePicker.StateCommon.Back.Color1 = Color.Gray;
            }

            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

            if (!isSearch) {
                TextBoxCod.ReadOnly = true;
                TextBoxCod.StateCommon.Back.Color1 = Color.Gray;
            }

            _isSearch = isSearch;
        }


        private void GoBack(object sender, EventArgs e) {
            this.Close();
        }

        private async void AddEditUser_Load(object sender, EventArgs e) {
            if (CurrentClient.CodigoClient == -1) return;

            var client = await Clients.GetClients($"WHERE codigo_cliente = {CurrentClient.CodigoClient}");

            if (client != null) {
                TextBoxCod.Text = client.Rows[0]["codigo_cliente"].ToString();
                TextBoxName.Text = client.Rows[0]["nome"].ToString();
                TextBoxCPF.Text = client.Rows[0]["cpf"].ToString();
                TextBoxRG.Text = client.Rows[0]["rg"].ToString();
                TextBoxProf.Text = client.Rows[0]["profissao"].ToString();
                TextBoxNasc.Text = client.Rows[0]["nacionalidade"].ToString();
                DatePicker.Value = (DateTime)client.Rows[0]["data_nascimento"];
                ComboBoxGen.Text = client.Rows[0]["genero"].ToString();
                ComboBoxEstCiv.Text = client.Rows[0]["estado_civil"].ToString();
                TextBoxStreet.Text = client.Rows[0]["rua"].ToString();
                TextBoxNumber.Text = client.Rows[0]["numero"].ToString();
                TextBoxComp.Text = client.Rows[0]["complemento"].ToString();
                TextBoxDistrict.Text = client.Rows[0]["bairro"].ToString();
                TextBoxCity.Text = client.Rows[0]["cidade"].ToString();
                ComboBoxUF.Text = client.Rows[0]["uf"].ToString();
                TextBoxCEP.Text = client.Rows[0]["cep"].ToString();
                TextBoxObs.Text = client.Rows[0]["observacoes"].ToString();
                TextBoxEmail.Text = client.Rows[0]["email"].ToString();
                TextBoxPhone.Text = client.Rows[0]["telefone"].ToString();
                TextBoxMobile.Text = client.Rows[0]["celular"].ToString();
                CheckBoxAtivo.Checked = (bool)client.Rows[0]["situacao"];
                CheckBoxIsZap.Checked = (bool)client.Rows[0]["whatsapp"];
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
            loadingForm = new Loading();
            loadingForm.Show();
            loadingForm.Refresh();

            if (!_isSearch) {
                if (
                    string.IsNullOrEmpty(TextBoxName.Text) ||
                    string.IsNullOrEmpty(TextBoxCPF.Text) ||
                    string.IsNullOrEmpty(TextBoxRG.Text) ||
                    string.IsNullOrEmpty(TextBoxNasc.Text) ||
                    DatePicker.Value == null ||
                    string.IsNullOrEmpty(ComboBoxGen.Text) ||
                    string.IsNullOrEmpty(ComboBoxEstCiv.Text) ||
                    string.IsNullOrEmpty(TextBoxStreet.Text) ||
                    string.IsNullOrEmpty(TextBoxNumber.Text) ||
                    string.IsNullOrEmpty(TextBoxDistrict.Text) ||
                    string.IsNullOrEmpty(TextBoxCity.Text) ||
                    string.IsNullOrEmpty(ComboBoxUF.Text) ||
                    string.IsNullOrEmpty(TextBoxCEP.Text) ||
                    string.IsNullOrEmpty(TextBoxPhone.Text) ||
                    string.IsNullOrEmpty(TextBoxMobile.Text)
                ) {
                    new Alert("Preencha todos os campos!", "").ShowDialog();
                    loadingForm.Close();
                    return;
                }
            }

            try {
                CurrentClient.CodigoClient = int.Parse(TextBoxCod?.Text);
            } catch { }

            CurrentClient.Nome = TextBoxName.Text;
            CurrentClient.CPF = TextBoxCPF.Text;
            CurrentClient.RG = TextBoxRG.Text;
            CurrentClient.Profissao = TextBoxProf.Text;
            CurrentClient.Nacionalidade = TextBoxNasc.Text;

            if (!_isSearch) {
                CurrentClient.DataNasc = DatePicker.Value.ToString("s");
            }

            CurrentClient.Genero = ComboBoxGen.Text;
            CurrentClient.EstadoCivil = ComboBoxEstCiv.Text;
            CurrentClient.Rua = TextBoxStreet.Text;
            CurrentClient.Numero = TextBoxNumber.Text == "" ? -1 : int.Parse(TextBoxNumber.Text);
            CurrentClient.Complemento = TextBoxComp.Text;
            CurrentClient.Bairro = TextBoxDistrict.Text;
            CurrentClient.Cidade = TextBoxCity.Text;
            CurrentClient.Uf = ComboBoxUF.Text;
            CurrentClient.CEP = TextBoxNumber.Text == "" ? -1 : int.Parse(TextBoxCEP.Text);
            CurrentClient.Obs = TextBoxObs.Text;
            CurrentClient.Email = TextBoxEmail.Text;
            CurrentClient.Telefone = TextBoxNumber.Text == "" ? -1 : int.Parse(TextBoxPhone.Text);
            CurrentClient.Celular = TextBoxNumber.Text == "" ? -1 : int.Parse(TextBoxMobile.Text);
            CurrentClient.Situacao = CheckBoxAtivo.Checked;
            CurrentClient.Whatsapp = CheckBoxIsZap.Checked;

            if (_isSearch) {
                loadingForm.Close();
                DialogResult dialogResult = DialogResult.OK;
                this.DialogResult = dialogResult;
                this.Close();
                return;
            };

            bool sucesso;
            if (CurrentClient.CodigoClient == -1) {
                sucesso = await Clients.CreateClient(CurrentClient);
            } else {
                sucesso = await Clients.UpdateClient(CurrentClient);
            }

            loadingForm.Close();

            if (sucesso) {
                new Success("Cliente", "Cliente salvo com sucesso!").ShowDialog();

                this.Close();
            } else {
                new Alert("Cliente", "Erro ao salvar cliente!").ShowDialog();
            }
        }

        private void ComboBoxCond_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
