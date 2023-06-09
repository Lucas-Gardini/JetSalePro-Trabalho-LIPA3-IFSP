namespace JetSalePro {
    // Classe global para armazenar variáveis globais
    static class Global {
        private static string _currentUser = "";

        public static string CurrentUser {
            get { return _currentUser; }
            set { _currentUser = value; }
        }
    }
}
