using JetSalePro.pages;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace JetSalePro.services {
    internal class User {
        #region Campos
        public int CodigoUsuario { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool Situacao { get; set; }
        public bool Adm { get; set; }
        #endregion

        #region Enums
        public enum SituacaoUsuario {
            Ativo = 1,
            Inativo = 0
        }

        public enum UserStatus {
            Invalid,
            Approved
        }
        #endregion

        #region Funções auxiliares
        public static string CryptToSha256(string toCrypt) {
            SHA256 senha = SHA256.Create();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(toCrypt);
            byte[] hash = senha.ComputeHash(bytes);
            string senhaHash = Convert.ToBase64String(hash);

            return senhaHash;
        }

        public static async Task<UserStatus> Authenticate(string username, string password) {
            MySqlConnection connection = await Database.GetConnectionAsync();

            password = CryptToSha256(password);

            MySqlCommand command = new MySqlCommand($"SELECT * FROM usuarios WHERE usuario = '{username}' AND senha = '{password}' AND situacao = 1", connection);

            try {
                DbDataReader reader = await command.ExecuteReaderAsync();
                return reader.HasRows ? UserStatus.Approved : UserStatus.Invalid;
            } catch (Exception ex) {
                new Alert("Usuário", ex.Message).ShowDialog();
                return UserStatus.Invalid;
            } finally {
                connection.Close();
            }
        }
        #endregion

        #region Funções relacionadas a Model

        public static async Task<bool> CreateUser(User newUser) {
            MySqlConnection connection = await Database.GetConnectionAsync();

            MySqlCommand command = new MySqlCommand($"INSERT INTO usuarios (nome, usuario, senha, situacao, adm) VALUES ('{newUser.Nome}', '{newUser.Usuario}', '{CryptToSha256(newUser.Senha)}', '{SituacaoUsuario.Inativo}', {false})", connection);

            try {
                await command.ExecuteNonQueryAsync();
                return true;
            } catch (Exception ex) {
                new Alert("Usuário", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        #endregion
    }
}
