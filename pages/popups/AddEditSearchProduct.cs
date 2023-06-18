using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.Properties;
using JetSalePro.services;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class AddEditSearchProduct : KryptonForm {
        // Modal de carregamento
        Loading loadingForm = new Loading();

        public Products CurrentProduct = new Products();

        private bool _isSearch = false;

        public AddEditSearchProduct(string productId, bool isSearch = false) {
            InitializeComponent();

            CurrentProduct.CodigoProduto = int.Parse(productId);

            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

            if (isSearch) {
                ButtonSave.Image = Resources.search_full;
                TextBoxCod.Enabled = true;
                TextBoxCod.ReadOnly = false;

                TextBoxCod.StateCommon.Back.Color1 = Color.LightGray;

                // Desabilitando campos numéricos (complicações no desenvolvimento e sem tempo de consertar)
                TextBoxLargura.Enabled = false;
                TextBoxLargura.ReadOnly = true;
                TextBoxAltura.Enabled = false;
                TextBoxAltura.ReadOnly = true;
                TextBoxProfun.Enabled = false;
                TextBoxProfun.ReadOnly = true;
                TextBoxPreco.Enabled = false;
                TextBoxPreco.ReadOnly = true;
                TextBoxQuant.Enabled = false;
                TextBoxQuant.ReadOnly = true;

                TextBoxLargura.StateCommon.Back.Color1 = Color.Gray;
                TextBoxAltura.StateCommon.Back.Color1 = Color.Gray;
                TextBoxProfun.StateCommon.Back.Color1 = Color.Gray;
                TextBoxPreco.StateCommon.Back.Color1 = Color.Gray;
                TextBoxQuant.StateCommon.Back.Color1 = Color.Gray;
            }

            ComboBoxCond.SelectedIndex = 0;

            _isSearch = isSearch;
        }


        private void GoBack(object sender, EventArgs e) {
            this.Close();
        }

        private async void AddEditUser_Load(object sender, EventArgs e) {
            if (CurrentProduct.CodigoProduto == -1) return;

            var product = await Products.GetProducts($"WHERE codigo_produto = {CurrentProduct.CodigoProduto}");

            if (product != null) {
                TextBoxCod.Text = product.Rows[0]["codigo_produto"].ToString();
                TextBoxDesc.Text = product.Rows[0]["descricao"].ToString();
                TextBoxCodBarras.Text = product.Rows[0]["codigo_barras"].ToString();
                TextBoxMarca.Text = product.Rows[0]["marca"].ToString();
                TextBoxPeso.Text = product.Rows[0]["peso"].ToString();
                TextBoxLargura.Text = product.Rows[0]["largura"].ToString();
                TextBoxAltura.Text = product.Rows[0]["altura"].ToString();
                TextBoxProfun.Text = product.Rows[0]["profundidade"].ToString();
                TextBoxPreco.Text = product.Rows[0]["preco_venda"].ToString();
                TextBoxQuant.Text = product.Rows[0]["quantidade_estoque"].ToString();

                ComboBoxCond.Text = product.Rows[0]["condicao"].ToString();
                CheckBoxAtivo.Checked = (bool)product.Rows[0]["situacao"];
            } else {
                new Alert("Produto", "Produto não encontrado!").ShowDialog();
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

        private async void ButtonSalvar_Click(object sender, EventArgs e) {
            loadingForm.Show();
            loadingForm.Refresh();

            try {
                CurrentProduct.CodigoProduto = string.IsNullOrEmpty(TextBoxCod.Text) ? -1 : int.Parse(TextBoxCod.Text.Replace('.', ','));
                CurrentProduct.Peso = string.IsNullOrEmpty(TextBoxPeso.Text) ? -1 : float.Parse(TextBoxPeso.Text.Replace('.', ','));
                CurrentProduct.Largura = string.IsNullOrEmpty(TextBoxLargura.Text) ? -1 : float.Parse(TextBoxLargura.Text.Replace('.', ','));
                CurrentProduct.Altura = string.IsNullOrEmpty(TextBoxAltura.Text) ? -1 : float.Parse(TextBoxAltura.Text.Replace('.', ','));
                CurrentProduct.Profundidade = string.IsNullOrEmpty(TextBoxProfun.Text) ? -1 : float.Parse(TextBoxProfun.Text.Replace('.', ','));
                CurrentProduct.PrecoVenda = string.IsNullOrEmpty(TextBoxPreco.Text) ? -1 : float.Parse(TextBoxPreco.Text.Replace('.', ','));
                CurrentProduct.Quantidade = string.IsNullOrEmpty(TextBoxQuant.Text) ? -1 : int.Parse(TextBoxQuant.Text.Replace('.', ','));
            } catch {
                new Alert("Atenção", "Você não inseriu valores numéricos válidos!").ShowDialog();
                loadingForm.Close();
                this.Close();
                return;
            }

            CurrentProduct.Descricao = TextBoxDesc.Text;
            CurrentProduct.CodigoBarras = TextBoxCodBarras.Text;
            CurrentProduct.Marca = TextBoxMarca.Text;
            CurrentProduct.Condicao = ComboBoxCond.Text;
            CurrentProduct.Situacao = CheckBoxAtivo.Checked;

            if (string.IsNullOrEmpty(CurrentProduct.Condicao)) {
                if (!_isSearch) {
                    new Alert("Atenção", "Você não escolheu uma condição!").ShowDialog();
                    loadingForm.Close();
                    return;
                }
            }

            if (_isSearch) {
                loadingForm.Close();
                DialogResult dialogResult = DialogResult.OK;
                this.DialogResult = dialogResult;
                this.Close();
                return;
            };

            bool sucesso;
            if (CurrentProduct.CodigoProduto == -1) {
                sucesso = await Products.CreateProduct(CurrentProduct);
            } else {
                sucesso = await Products.UpdateProduct(CurrentProduct);
            }

            loadingForm.Close();

            if (sucesso) {
                new Success("Produto", "Produto salvo com sucesso!").ShowDialog();

                this.Close();
            } else {
                new Alert("Produto", "Erro ao salvar produto!").ShowDialog();

                this.Close();
            }
        }
    }
}
