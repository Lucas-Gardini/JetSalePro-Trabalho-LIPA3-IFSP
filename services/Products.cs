using JetSalePro.pages;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace JetSalePro.services {
    public class Products {
        #region Campos
        public int CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public string CodigoBarras { get; set; }
        public string Marca { get; set; }
        public float Peso { get; set; }
        public float Largura { get; set; }
        public float Altura { get; set; }
        public float Profundidade { get; set; }
        public bool Situacao { get; set; }
        public string Condicao { get; set; }
        public float PrecoVenda { get; set; }
        public int Quantidade { get; set; }
        #endregion

        #region Enums
        public enum SituacaoProduto {
            Ativo = 1,
            Inativo = 0
        }
        #endregion

        #region Funções relacionadas a Model
        public static async Task<bool> UpdateProduct(Products product) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            string updateQuery = $"UPDATE produtos SET descricao = '{product.Descricao}', codigo_barras = '{product.CodigoBarras}', marca = '{product.Marca}', peso = {product.Peso.ToString().Replace(',', '.')}, largura = {product.Largura.ToString().Replace(',', '.')}, altura = {product.Altura.ToString().Replace(',', '.')}, profundidade = {product.Profundidade.ToString().Replace(',', '.')}, situacao = {(product.Situacao ? 1 : 0)}, condicao = '{product.Condicao}', preco_venda = {product.PrecoVenda.ToString().Replace(',', '.')}, quantidade_estoque = {product.Quantidade} ";

            updateQuery += $" WHERE codigo_produto = {product.CodigoProduto}";

            MySqlCommand command = new MySqlCommand(updateQuery, connection);

            try {
                await command.ExecuteNonQueryAsync();
                return true;
            } catch (Exception ex) {
                new Alert("Produto", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        public static async Task<bool> CreateProduct(Products newProduct) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($"INSERT INTO produtos (descricao, codigo_barras, marca, peso, largura, altura, profundidade, situacao, condicao, preco_venda, quantidade_estoque) VALUES ('{newProduct.Descricao}', '{newProduct.CodigoBarras}', '{newProduct.Marca}', '{newProduct.Peso.ToString().Replace(',', '.')}', '{newProduct.Largura.ToString().Replace(',', '.')}', '{newProduct.Altura.ToString().Replace(',', '.')}', '{newProduct.Profundidade.ToString().Replace(',', '.')}', {(newProduct.Situacao ? 1 : 0)}, '{newProduct.Condicao}', '{newProduct.PrecoVenda.ToString().Replace(',', '.')}', '{newProduct.Quantidade}')", connection);

            try {
                await command.ExecuteNonQueryAsync();
                return true;
            } catch (Exception ex) {
                new Alert("Produto", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        public static async Task<DataTable> GetProducts(string WHERE = null) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            if (WHERE != null) {
                WHERE = WHERE.Replace(",", ".");
            }

            MySqlCommand command = new MySqlCommand($"SELECT * FROM produtos {WHERE}", connection);

            try {
                // Instância do DataTable (contém os dados) e do adapter (executa a query)
                DataTable dataTable = new DataTable();

                // Executando a query e preenchendo o DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Preenchendo o DataTable
                await adapter.FillAsync(dataTable);

                return dataTable;
            } catch (Exception ex) {
                new Alert("Produtos", ex.Message).ShowDialog();
                return null;
            } finally {
                connection.Close();
            }
        }

        public static async Task<bool> DeleteProduct(string id) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($"DELETE FROM produtos WHERE codigo_produto = {id}", connection);

            try {
                int rowsAffected = await command.ExecuteNonQueryAsync();
                return rowsAffected > 0; // Retorna true se pelo menos uma linha foi afetada (produto excluído com sucesso)
            } catch (Exception ex) {
                new Alert("Produto", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }
		#endregion

		#region Funções para relatório
		public static async Task<DataTable> GetProductsMoreSale(string WHERE = null)
		{
			MySqlConnection connection = await Database.GetConnectionAsync(true);

			// 10 produtos mais vendidos
			string query = "select SUM(iv.quantidade), v.data_venda, p.descricao ";
			query += "from produtos p, vendas v, itens_venda iv ";
			query += $"where v.codigo_venda = iv.codigo_venda AND iv.codigo_produto = p.codigo_produto AND {WHERE} ";
			query += "GROUP BY p.codigo_produto ORDER BY SUM(iv.quantidade) DESC LIMIT 10";
			
			MySqlCommand command = new MySqlCommand(query, connection);

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