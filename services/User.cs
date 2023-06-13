using JetSalePro.pages;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace JetSalePro.services
{
	public class User
	{
		#region Campos
		public int CodigoUsuario { get; set; }
		public string Nome { get; set; }
		public string Usuario { get; set; }
		public string Senha { get; set; }
		public bool Situacao { get; set; }
		public bool Adm { get; set; }
		#endregion

		#region Enums
		public enum SituacaoUsuario
		{
			Ativo = 1,
			Inativo = 0
		}

		public enum UserStatus
		{
			Invalid,
			Approved
		}
		#endregion

		#region Funções auxiliares
		public static string CryptToSha256(string toCrypt)
		{
			SHA256 senha = SHA256.Create();
			byte[] bytes = System.Text.Encoding.UTF8.GetBytes(toCrypt);
			byte[] hash = senha.ComputeHash(bytes);
			string senhaHash = Convert.ToBase64String(hash);

			return senhaHash;
		}

		public static async Task<UserStatus> Authenticate(string username, string password)
		{
			MySqlConnection connection = await Database.GetConnectionAsync();

			password = CryptToSha256(password);

			MySqlCommand command = new MySqlCommand($"SELECT * FROM usuarios WHERE usuario = '{username}' AND senha = '{password}' AND situacao = 1", connection);

			try
			{
				DbDataReader reader = await command.ExecuteReaderAsync();
				return reader.HasRows ? UserStatus.Approved : UserStatus.Invalid;
			}
			catch (Exception ex)
			{
				new Alert("Usuário", ex.Message).ShowDialog();
				return UserStatus.Invalid;
			}
			finally
			{
				connection.Close();
			}
		}

		public static async Task<bool> IsAdministrator(string username)
		{
			MySqlConnection connection = await Database.GetConnectionAsync();

			MySqlCommand command = new MySqlCommand($"SELECT adm FROM usuarios WHERE usuario = '{username}'", connection);

			try
			{
				object result = await command.ExecuteScalarAsync();
				if (result != null && result != DBNull.Value)
				{
					bool isAdmin = Convert.ToBoolean(result);
					return isAdmin;
				}
			}
			catch (Exception ex)
			{
				new Alert("Usuário", ex.Message).ShowDialog();
			}
			finally
			{
				connection.Close();
			}
			return false;
		}
		#endregion

		#region Funções relacionadas a Model

		public static async Task<bool> CreateUser(User newUser)
		{
			MySqlConnection connection = await Database.GetConnectionAsync();

			MySqlCommand command = new MySqlCommand($"INSERT INTO usuarios (nome, usuario, senha, situacao, adm) VALUES ('{newUser.Nome}', '{newUser.Usuario}', '{CryptToSha256(newUser.Senha)}', {(newUser.Situacao ? 1 : 0)}, {newUser.Adm})", connection);

			try
			{
				await command.ExecuteNonQueryAsync();
				return true;
			}
			catch (Exception ex)
			{
				new Alert("Usuário", ex.Message).ShowDialog();
				return false;
			}
			finally
			{
				connection.Close();
			}
		}

		public static async Task<bool> UpdateUser(User user, bool updatePassword)
		{
			MySqlConnection connection = await Database.GetConnectionAsync();

			string updateQuery = $"UPDATE usuarios SET nome = '{user.Nome}', usuario = '{user.Usuario}', situacao = {(user.Situacao ? 1 : 0)}, adm = {(user.Adm)}";

			if (updatePassword)
			{
				updateQuery += $", senha = '{CryptToSha256(user.Senha)}'";
			}

			updateQuery += $" WHERE codigo_usuario = {user.CodigoUsuario}";

			MySqlCommand command = new MySqlCommand(updateQuery, connection);

			try
			{
				await command.ExecuteNonQueryAsync();
				return true;
			}
			catch (Exception ex)
			{
				new Alert("Usuário", ex.Message).ShowDialog();
				return false;
			}
			finally
			{
				connection.Close();
			}
		}

		public static async Task<bool> DeleteUser(string id)
		{
			MySqlConnection connection = await Database.GetConnectionAsync();

			MySqlCommand command = new MySqlCommand($"DELETE FROM usuarios WHERE codigo_usuario = {id}", connection);

			try
			{
				int rowsAffected = await command.ExecuteNonQueryAsync();
				return rowsAffected > 0; // Retorna true se pelo menos uma linha foi afetada (usuário excluído com sucesso)
			}
			catch (Exception ex)
			{
				new Alert("Usuário", ex.Message).ShowDialog();
				return false;
			}
			finally
			{
				connection.Close();
			}
		}


		public static async Task<DataTable> GetUsers(string WHERE = null)
		{
			MySqlConnection connection = await Database.GetConnectionAsync();

			MySqlCommand command = new MySqlCommand($"SELECT * FROM usuarios {WHERE}", connection);

			try
			{
				// Instância do DataTable (contém os dados) e do adapter (executa a query)
				DataTable dataTable = new DataTable();

				// Executando a query e preenchendo o DataTable
				MySqlDataAdapter adapter = new MySqlDataAdapter(command);

				// Preenchendo o DataTable
				await adapter.FillAsync(dataTable);

				return dataTable;
			}
			catch (Exception ex)
			{
				new Alert("Usuários", ex.Message).ShowDialog();
				return null;
			}
			finally
			{
				connection.Close();
			}
		}
		#endregion
	}
}
