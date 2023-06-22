using JetSalePro.pages;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace JetSalePro.services {
    public class Sales {
        #region Campos
        public int CodigoVenda { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoCliente { get; set; }
        public dynamic DataVenda { get; set; }
        public int TotalItens { get; set; }
        public float Subtotal { get; set; }
        public float Desconto { get; set; }
        public float ValorTotal { get; set; }
        public string FormaPagamento { get; set; }
        public string Situacao { get; set; }
        public string Obs { get; set; }
        #endregion

        #region Enums
        #endregion

        #region Funções relacionadas a Model
        public static async Task<DataTable> GetSales(string WHERE = null) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($"SELECT * FROM vendas {WHERE}", connection);

            try {
                // Instância do DataTable (contém os dados) e do adapter (executa a query)
                DataTable dataTable = new DataTable();

                // Executando a query e preenchendo o DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Preenchendo o DataTable
                await adapter.FillAsync(dataTable);

                return dataTable;
            } catch (Exception ex) {
                new Alert("Vendas", ex.Message).ShowDialog();
                return null;
            } finally {
                connection.Close();
            }
        }

        public static async Task<bool> CreateSale(Sales sale) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($@"INSERT INTO vendas 
                (codigo_usuario, codigo_cliente, data_venda, total_itens, subtotal, desconto, valor_total, forma_pagamento, situacao, observacoes)
                VALUES 
                ({sale.CodigoUsuario}, {sale.CodigoCliente}, '{((DateTime)sale.DataVenda).ToString("s")}', {sale.TotalItens}, {sale.Subtotal.ToString().Replace(",", ".")}, {sale.Desconto.ToString().Replace(",", ".")}, {sale.ValorTotal.ToString().Replace(",", ".")}, '{sale.FormaPagamento}', '{sale.Situacao}', '{sale.Obs}')", connection);

            try {
                await command.ExecuteNonQueryAsync();
                return true;
            } catch (Exception ex) {
                new Alert("Venda", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        public static async Task<bool> UpdateSale(Sales sale) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($@"UPDATE vendas SET 
                codigo_usuario = {sale.CodigoUsuario}, 
                codigo_cliente = {sale.CodigoCliente}, 
                data_venda = '{((DateTime)sale.DataVenda).ToString("s")}', 
                total_itens = {sale.TotalItens}, 
                subtotal = {sale.Subtotal.ToString().Replace(",", ".")}, 
                desconto = {sale.Desconto.ToString().Replace(",", ".")}, 
                valor_total = {sale.ValorTotal.ToString().Replace(",", ".")}, 
                forma_pagamento = '{sale.FormaPagamento}', 
                situacao = '{sale.Situacao}', 
                observacoes = '{sale.Obs}' 
                WHERE codigo_venda = {sale.CodigoVenda}", connection);

            try {
                await command.ExecuteNonQueryAsync();
                return true;
            } catch (Exception ex) {
                new Alert("Venda", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        public static async Task<bool> DeleteSale(string id) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand deleteItensVenda = new MySqlCommand($"DELETE FROM itens_venda WHERE codigo_venda = {id}", connection);
            MySqlCommand command = new MySqlCommand($"DELETE FROM vendas WHERE codigo_venda = {id}", connection);

            try {
                await deleteItensVenda.ExecuteNonQueryAsync();

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
