using ComponentFactory.Krypton.Toolkit;
using System.Threading;
using System.Windows.Forms;

// Código retirado de: https://stackoverflow.com/questions/510765/c-sharp-winforms-startup-splash-form-not-hiding/510786#510786
namespace JetSalePro.pages {
    public partial class Loading : KryptonForm {
        public Loading() {
            InitializeComponent();
        }

        private delegate void CloseDelegate();

        private static Loading splashForm;

        public void ShowSplashScreen() {
            if (splashForm != null)
                return;

            Thread thread = new Thread(new ThreadStart(this.ShowForm)) {
                IsBackground = true
            };

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void ShowForm() {
            splashForm = new Loading();
            Application.Run(splashForm);
        }

        public void CloseForm() {
            if (splashForm == null) return;
            splashForm.Invoke(new CloseDelegate(CloseFormInternal));
        }

        private void CloseFormInternal() {
            splashForm.Close();
            splashForm = null;
        }

        private void Loading_Load(object sender, System.EventArgs e) {

        }
    }
}
