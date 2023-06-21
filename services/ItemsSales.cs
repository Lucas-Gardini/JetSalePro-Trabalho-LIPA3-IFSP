using JetSalePro.pages;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace JetSalePro.services {
    public class ItemsSales {
        #region Campos
        public int CodigoItemVenda { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public float ValorUnitario { get; set; }
        public float SubtotalProduto { get; set; }
        #endregion

        #region Enums
        #endregion

        #region Funções relacionadas a Model
        public static async Task<DataTable> GetItemSales(string WHERE = null) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($"SELECT * FROM itens_venda {WHERE}", connection);

            try {
                // Instância do DataTable (contém os dados) e do adapter (executa a query)
                DataTable dataTable = new DataTable();

                // Executando a query e preenchendo o DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Preenchendo o DataTable
                await adapter.FillAsync(dataTable);

                return dataTable;
            } catch (Exception ex) {
                new Alert("Itens Vendas", ex.Message).ShowDialog();
                return null;
            } finally {
                connection.Close();
            }
        }

        public static async Task<bool> CreateItemSale(ItemsSales sale) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($@"INSERT INTO itens_venda (codigo_venda, codigo_produto, quantidade, descricao, valor_unitario, subtotal_produto)
                                      VALUES ({sale.CodigoVenda}, {sale.CodigoProduto}, {sale.Quantidade}, '{sale.Descricao}', {sale.ValorUnitario.ToString().Replace(',', '.')}, {sale.SubtotalProduto.ToString().Replace(',', '.')})", connection);

            try {
                await command.ExecuteNonQueryAsync();

                // Atualizar quantidade e situação do produto
                string updateProductQuery = $@"UPDATE produtos
                                SET quantidade_estoque = quantidade_estoque - 1,
                                    situacao = IF(quantidade_estoque - 1 > 0, 1, 0)
                                WHERE codigo_produto = {sale.CodigoProduto}";
                MySqlCommand updateProductCommand = new MySqlCommand(updateProductQuery, connection);
                await updateProductCommand.ExecuteNonQueryAsync();

                return true;
            } catch (Exception ex) {
                new Alert("Itens Vendas", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }


        public static async Task<bool> UpdateItemSale(ItemsSales sale) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            string updateQuery = $@"UPDATE itens_venda SET codigo_venda = {sale.CodigoVenda}, codigo_produto = {sale.CodigoProduto}, quantidade = {sale.Quantidade}, descricao = '{sale.Descricao}', valor_unitario = {sale.ValorUnitario.ToString().Replace(',', '.')}, subtotal_produto = {sale.SubtotalProduto.ToString().Replace(',', '.')}
                            WHERE codigo_item_venda = {sale.CodigoItemVenda}";

            MySqlCommand command = new MySqlCommand(updateQuery, connection);

            try {
                await command.ExecuteNonQueryAsync();
                return true;
            } catch (Exception ex) {
                new Alert("Itens Vendas", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        public static async Task<bool> IncrementQuantity(int itemSaleId) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            string updateQuery = $@"UPDATE itens_venda 
                            SET quantidade = quantidade + 1,
                                subtotal_produto = valor_unitario * (quantidade + 1)
                            WHERE codigo_item_venda = {itemSaleId}";

            MySqlCommand command = new MySqlCommand(updateQuery, connection);

            try {
                await command.ExecuteNonQueryAsync();

                // Atualizar quantidade e situação do produto
                string updateProductQuery = $@"UPDATE produtos
                                        SET quantidade_estoque = quantidade_estoque - 1,
                                            situacao = IF(quantidade_estoque - 1 > 0, 1, 0)
                                        WHERE codigo_produto = (SELECT codigo_produto FROM itens_venda WHERE codigo_item_venda = {itemSaleId})";
                MySqlCommand updateProductCommand = new MySqlCommand(updateProductQuery, connection);
                await updateProductCommand.ExecuteNonQueryAsync();

                return true;
            } catch (Exception ex) {
                new Alert("Itens Vendas", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        public static async Task<bool> DecrementQuantity(int itemSaleId) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            string updateQuery = $@"UPDATE itens_venda 
                            SET quantidade = quantidade - 1,
                                subtotal_produto = valor_unitario * (quantidade - 1)
                            WHERE codigo_item_venda = {itemSaleId}";

            MySqlCommand command = new MySqlCommand(updateQuery, connection);

            try {
                await command.ExecuteNonQueryAsync();

                // Atualizar quantidade e situação do produto
                string updateProductQuery = $@"UPDATE produtos
                                        SET quantidade_estoque = quantidade_estoque + 1,
                                            situacao = IF(quantidade_estoque + 1 >= 0, 1, 0)
                                        WHERE codigo_produto = (SELECT codigo_produto FROM itens_venda WHERE codigo_item_venda = {itemSaleId})";
                MySqlCommand updateProductCommand = new MySqlCommand(updateProductQuery, connection);
                await updateProductCommand.ExecuteNonQueryAsync();

                return true;
            } catch (Exception ex) {
                new Alert("Itens Vendas", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }


        public static async Task<bool> DeleteItemSale(string id, int toRestore) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($"DELETE FROM itens_venda WHERE codigo_item_venda = {id}", connection);

            try {
                // Atualizar quantidade e situação do produto
                string updateProductQuery = $@"UPDATE produtos
                                        SET quantidade_estoque = quantidade_estoque + {toRestore},
                                            situacao = IF(quantidade_estoque + {toRestore} > 0, 1, 0)
                                        WHERE codigo_produto = (SELECT codigo_produto FROM itens_venda WHERE codigo_item_venda = {id})";
                MySqlCommand updateProductCommand = new MySqlCommand(updateProductQuery, connection);
                await updateProductCommand.ExecuteNonQueryAsync();

                int rowsAffected = await command.ExecuteNonQueryAsync();

                return rowsAffected > 0;
            } catch (Exception ex) {
                new Alert("Venda", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        #endregion
    }
}
