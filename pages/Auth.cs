using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.services;
using System;
using System.Threading;
using System.Windows.Forms;
using static JetSalePro.services.User;

namespace JetSalePro {
    public partial class Auth : KryptonForm {
        // Enum das duas formas de autenticação
        private enum AuthType {
            Login,
            Register
        }

        // Variável que guarda a forma de autenticação atual
        private AuthType CurrentAuthType = AuthType.Login;

        // Modal de carregamento
        Loading loadingForm = new Loading();

        public Auth() {
            InitializeComponent();

            // Desabilitando os botões de login e registro
            ButtonLogin.Enabled = false;
            ButtonRegister.Enabled = false;

            this.Opacity = 0;

            TextBoxName.Hide();
        }

        // Função de inicialização do componente, responsável por aguardar a criação do banco de dados
        private async void Login_Load(object sender, System.EventArgs e) {
            ButtonLogin.Cursor = Cursors.Hand;
            ButtonRegister.Cursor = Cursors.Hand;

            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

            loadingForm.ShowSplashScreen();

            await Database.CreateDatabase();

            loadingForm.CloseForm();

            // Forçando a exibição da janela
            this.WindowState = FormWindowState.Minimized;
            this.Opacity = 1;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            // habilitando os botões de login e registro
            ButtonLogin.Enabled = true;
            ButtonRegister.Enabled = true;
        }

        // Altera o caractere do campo de senha, caso o tamanho seja > 0
        private void TextBoxPassword_TextChanged(object sender, System.EventArgs e) {
            if (TextBoxPassword.Text.Length > 0)
                TextBoxPassword.PasswordChar = '*';
            else
                TextBoxPassword.PasswordChar = '\0';
        }

        // Função auxiliar de placeholder
        private void TextBoxUser_Enter(object sender, System.EventArgs e) {
            if (TextBoxUser.Text == "Usuário") {
                TextBoxUser.Text = string.Empty;
            }
        }

        // Função auxiliar de placeholder
        private void TextBoxUser_Leave(object sender, System.EventArgs e) {
            if (TextBoxUser.Text == string.Empty) {
                TextBoxUser.Text = "Usuário";
            }
        }

        // Função auxiliar de placeholder
        private void TextBoxName_Enter(object sender, EventArgs e) {
            if (TextBoxName.Text == "Nome") {
                TextBoxName.Text = string.Empty;
            }
        }

        // Função auxiliar de placeholder
        private void TextBoxName_Leave(object sender, EventArgs e) {
            if (TextBoxName.Text == string.Empty) {
                TextBoxName.Text = "Nome";
            }
        }

        // Função auxiliar de placeholder
        private void TextBoxPassword_Enter(object sender, System.EventArgs e) {
            if (TextBoxPassword.Text == "Senha") {
                TextBoxPassword.Text = string.Empty;
            }
        }

        // Função auxiliar de placeholder
        private void TextBoxPassword_Leave(object sender, System.EventArgs e) {
            if (TextBoxPassword.Text == string.Empty) {
                TextBoxPassword.Text = "Senha";
                TextBoxPassword.PasswordChar = '\0';
            }
        }

        // Função auxiliar que deixa a imagem responsiva
        private void Login_SizeChanged(object sender, System.EventArgs e) {
            if (this.Size.Width < 921) {
                PictureLogin.Hide();
            } else {
                PictureLogin.Show();
            }
        }

        // Função auxiliar que altera o tipo de autenticação
        private void ChangeAuthType(object sender, EventArgs e) {
            CurrentAuthType = CurrentAuthType == AuthType.Login ? AuthType.Register : AuthType.Login;

            if (CurrentAuthType == AuthType.Login) {
                ButtonLogin.Text = "Entrar";
                ButtonRegister.Text = "Não tem uma conta?";

                TextBoxUser.Width = 379;
                TextBoxName.Hide();
            } else {
                ButtonLogin.Text = "Registrar";
                ButtonRegister.Text = "Já tem uma conta?";

                TextBoxUser.Width = (379 / 2) - 10;
                TextBoxName.Show();
            }
        }

        // Função de autenticação
        private async void ButtonLogin_Click(object sender, EventArgs e) {
            string user = TextBoxUser.Text;
            string password = TextBoxPassword.Text;
            string name = TextBoxName.Text;

            // Validação de campos
            if (user == string.Empty || user == "Usuário") {
                new Alert("Preencha todos os campos!", "Campo 'Usuário' vazio!").ShowDialog();
                return;
            }
            if (password == string.Empty || password == "Senha") {
                new Alert("Preencha todos os campos!", "Campo 'Senha' vazio!").ShowDialog();
                return;
            }

            if (CurrentAuthType == AuthType.Register && (name == string.Empty || name == "Nome")) {
                new Alert("Preencha todos os campos!", "Campo 'Nome' vazio!").ShowDialog();
                return;
            }

            // Exibição da tela de carregamento
            loadingForm.ShowSplashScreen();
            Thread.Sleep(500);

            // Execução da autenticação
            switch (CurrentAuthType) {
                case AuthType.Login:
                    UserStatus validUser = await User.Authenticate(user, password);

                    // Fechamento da tela de carregamento
                    loadingForm.CloseForm();

                    if (validUser == UserStatus.Approved) {
                        Global.CurrentUser = user;

                        this.Close();
                        new Thread(() => Application.Run(new Dashboard())).Start();
                    } else if (validUser == UserStatus.Invalid) {
                        Alert alert = new Alert("Erro no login", "Usuário aguardando aprovação ou credenciais inválidas!");
                        alert.ShowDialog();
                    }
                    break;

                case AuthType.Register:
                    bool createdUser = await User.CreateUser(new User() {
                        Nome = name,
                        Usuario = user,
                        Senha = password,
                        Adm = false,
                    });

                    // Fechamento da tela de carregamento
                    loadingForm.CloseForm();

                    if (createdUser) {
                        TextBoxUser.Text = "Usuário";
                        TextBoxPassword.Text = "Senha";
                        TextBoxPassword.PasswordChar = '\0';
                        TextBoxName.Text = "Nome";
                        new Success("Sucesso", "Usuário criado com sucesso!\nAguarde a aprovação de um admnistrador.").ShowDialog();
                    } else {
                        Alert alert = new Alert("Erro ao criar usuário", "Usuário ou senha inválidos");
                        alert.ShowDialog();
                    }
                    break;

                default: break;
            }
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.ButtonLogin_Click(sender, e);
            }
        }
    }
}
