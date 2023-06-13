using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.Properties;
using JetSalePro.services;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace JetSalePro
{
	public partial class AddEditProduct : KryptonForm
	{
		// Modal de carregamento
		Loading loadingForm = new Loading();

		private Products _product { get; set; } = new Products();

		public AddEditProduct(string productId)
		{
			InitializeComponent();

			_product.CodigoProduto = int.Parse(productId);

			LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

			TextBoxCod.Enabled = false;
			TextBoxCod.ReadOnly = true;
			ComboBoxCond.SelectedIndex = 0;
		}


		private void GoBack(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void AddEditUser_Load(object sender, EventArgs e)
		{
			if (_product.CodigoProduto == -1) return;

			var product = await Products.GetProducts($"WHERE codigo_produto = {_product.CodigoProduto}");

			if (product != null)
			{
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
			}
			else
			{
				new Alert("Produto", "Produto não encontrado!").ShowDialog();
			}
		}

		private void SuccessIcon_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
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

		private async void ButtonSalvar_Click(object sender, EventArgs e)
		{
			loadingForm.Show();
			loadingForm.Refresh();

			try {
				_product.Peso = float.Parse(TextBoxPeso.Text);
				_product.Largura = float.Parse(TextBoxLargura.Text);
				_product.Altura = float.Parse(TextBoxAltura.Text);
				_product.Profundidade = float.Parse(TextBoxProfun.Text);
				_product.PrecoVenda = float.Parse(TextBoxPreco.Text);
				_product.Quantidade = int.Parse(TextBoxQuant.Text);
			}
			catch
			{
				new Alert("Atenção", "Você não inseriu valores numéricos válidos!").ShowDialog();
				loadingForm.Close();
				this.Close();
				return;
			}

			_product.Descricao = TextBoxDesc.Text;
			_product.CodigoBarras = TextBoxCodBarras.Text;
			_product.Marca = TextBoxMarca.Text;
			_product.Condicao = ComboBoxCond.Text;
			_product.Situacao = CheckBoxAtivo.Checked;

			bool sucesso;
			if (_product.CodigoProduto == -1)
			{
				sucesso = await Products.CreateProduct(_product);
			}
			else
			{
				sucesso = await Products.UpdateProduct(_product);
			}

			loadingForm.Close();

			if (sucesso)
			{
				new Success("Produto", "Produto salvo com sucesso!").ShowDialog();

				this.Close();
			}
			else
			{
				new Alert("Produto", "Erro ao salvar produto!").ShowDialog();

				this.Close();
			}
		}
	}
}
