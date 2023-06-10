namespace JetSalePro {
    // Classe global para armazenar variáveis globais
    static class Global {
        private static string _currentUser = "";
		private static bool _adm = false;

		public static string CurrentUser {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

		public static bool Adm {
			get { return _adm; }
			set { _adm = value; }
		}
    }
}
