using System.Drawing;
using System.Windows.Forms;

namespace JetSalePro {
    // Classe global para armazenar variáveis globais
    static class Global {
        private static string _currentUser = "";
        private static bool _adm = false;
        private static Size _formSize = new Size(0, 0);
        private static bool _formMaximized = false;

        public static string CurrentUser {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        public static bool Adm {
            get { return _adm; }
            set { _adm = value; }
        }

        public static Size FormSize {
            get { return _formSize; }
            set { _formSize = value; }
        }

        public static bool FormMaximized {
            get { return _formMaximized; }
            set { _formMaximized = value; }
        }

        public static void FormResize(Form form) {
            _formSize = form.Size;

            // Obtendo a resolução, para detectar se a janela foi maximizada
            Screen myScreen = Screen.FromControl(form);
            Rectangle area = myScreen.WorkingArea;

            if (_formSize.Width >= area.Width - 100) {
                _formMaximized = true;
            } else {
                _formMaximized = false;
            }
        }
    }
}
