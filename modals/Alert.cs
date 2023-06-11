using ComponentFactory.Krypton.Toolkit;

// Código retirado de: https://stackoverflow.com/questions/510765/c-sharp-winforms-startup-splash-form-not-hiding/510786#510786
namespace JetSalePro.pages {
    public partial class Alert : KryptonForm {
        private string Title { get; set; }
        private string Message { get; set; }

        public Alert(string title, string message, bool confirm = false) {
            InitializeComponent();

            Title = title;
            Message = message;

            if (!confirm) ButtonConfirm.Hide();
        }

        private void Alert_Load(object sender, System.EventArgs e) {
            LabelTile.Text = Title;
            LabelMessage.Text = Message;
        }

        private void ButtonLogin_Click(object sender, System.EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel; // Set the dialog result
            this.Close();
        }

        private void ButtonConfirm_Click(object sender, System.EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.OK; // Set the dialog result
            Close(); // Close the dialog form
        }
    }
}
