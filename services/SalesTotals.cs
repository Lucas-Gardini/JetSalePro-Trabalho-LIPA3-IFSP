using JetSalePro.pages;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace JetSalePro.services
{
    public class SalesTotals
    {
		public static async Task<int> GetSalesCount(string WHERE = null)
		{
			MySqlConnection connection = await Database.GetConnectionAsync(true);

			// 10 produtos mais vendidos
			string query = "SELECT COUNT(v.codigo_venda) ";
			query += $"FROM vendas v Where {WHERE}";

			MySqlCommand command = new MySqlCommand(query, connection);

			try
			{
				// Executando a query e obtendo o resultado de COUNT
				int count = Convert.ToInt32(await command.ExecuteScalarAsync());
				return count;
			}
			catch
			{
				return 0;
			}
			finally
			{
				connection.Close();
			}
		}

		public static async Task<float> GetSalesSum(string WHERE = null)
		{
			MySqlConnection connection = await Database.GetConnectionAsync(true);

			// 10 produtos mais vendidos
			string query = "SELECT SUM(v.valor_total) ";
			query += $"FROM vendas v Where {WHERE}";

			MySqlCommand command = new MySqlCommand(query, connection);

			try
			{
				// Executando a query e obtendo o resultado de SUM
				float count = Convert.ToSingle(await command.ExecuteScalarAsync());
				return count;
			}
			catch
			{
				return 0;
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
