using JetSalePro.pages;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System.Globalization;

namespace JetSalePro.services
{
	class Clients
	{
		#region Campos
		public int CodigoClient { get; set; }
		public string Nome { get; set; }
		public bool Situacao { get; set; }
		public string CPF { get; set; }
		public string RG { get; set; }
		public int Genero { get; set; }
		public string DataNasc { get; set; }
		public int EstadoCivil { get; set; }
		public string Profissao { get; set; }
		public string Nacionalidade { get; set; }
		public int Telefone { get; set; }
		public int Celular { get; set; }
		public bool Whatsapp { get; set; }
		public string Email { get; set; }
		public string Obs { get; set; }

		// Endereço
		public string Rua { get; set; }
		public int Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Uf { get; set; }
		public int CEP { get; set; }
		#endregion

		#region Enums
		public enum SituacaoCliente
		{
			Ativo = 1,
			Inativo = 0
		}

		public enum GeneroCliente
		{
			Masculino = 0,
			Feminino = 1,
			Naodeclarar = 2
		}

		public enum EstadoCivilCliente
		{
			Solteiro = 0,
			Casado = 1,
			Separado = 2,
			Divorciado = 3,
			Viuvo = 4
		}
		#endregion

		#region Funções relacionadas a Model
		public static async Task<DataTable> GetClients(string WHERE = null)
		{
			MySqlConnection connection = await Database.GetConnectionAsync();

			MySqlCommand command = new MySqlCommand($"SELECT * FROM clientes {WHERE}", connection);

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
				new Alert("Produtos", ex.Message).ShowDialog();
				return null;
			}
			finally
			{
				connection.Close();
			}
		}

		public static async Task<bool> DeleteClient(string id)
		{
			MySqlConnection connection = await Database.GetConnectionAsync();

			MySqlCommand command = new MySqlCommand($"DELETE FROM clientes WHERE codigo_cliente = {id}", connection);

			try
			{
				int rowsAffected = await command.ExecuteNonQueryAsync();
				return rowsAffected > 0;
			}
			catch (Exception ex)
			{
				new Alert("Cliente", ex.Message).ShowDialog();
				return false;
			}
			finally
			{
				connection.Close();
			}
		}
		#endregion
	}
}