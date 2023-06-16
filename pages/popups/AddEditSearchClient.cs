using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.Properties;
using JetSalePro.services;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace JetSalePro
{
	public partial class AddEditSearchClient : KryptonForm
	{
		// Modal de carregamento
		Loading loadingForm = new Loading();

		private Clients _cliente { get; set; } = new Clients();

		public AddEditSearchClient(string clienteId)
		{
			InitializeComponent();

			_cliente.CodigoClient = int.Parse(clienteId);

			LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

			TextBoxCod.ReadOnly = true;
		}


		private void GoBack(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void AddEditUser_Load(object sender, EventArgs e)
		{
			
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
			
		}
	}
}
