using JetSalePro.pages;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace JetSalePro.services {
    public class Clients {
        #region Campos
        public int CodigoClient { get; set; }
        public string Nome { get; set; }
        public bool Situacao { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Genero { get; set; }
        public dynamic DataNasc { get; set; }
        public string EstadoCivil { get; set; }
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
        public enum SituacaoCliente {
            Ativo = 1,
            Inativo = 0
        }

        public enum GeneroCliente {
            Masculino = 0,
            Feminino = 1,
            Naodeclarar = 2
        }

        public enum EstadoCivilCliente {
            Solteiro = 0,
            Casado = 1,
            Separado = 2,
            Divorciado = 3,
            Viuvo = 4
        }
        #endregion

        #region Funções relacionadas a Model
        public static async Task<DataTable> GetClients(string WHERE = null) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($"SELECT * FROM clientes {WHERE}", connection);

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

        public static async Task<bool> DeleteClient(string id) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($"DELETE FROM clientes WHERE codigo_cliente = {id}", connection);

            try {
                int rowsAffected = await command.ExecuteNonQueryAsync();
                return rowsAffected > 0;
            } catch (Exception ex) {
                new Alert("Cliente", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        static public async Task<bool> CreateClient(Clients client) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            MySqlCommand command = new MySqlCommand($"INSERT INTO clientes (nome, situacao, cpf, rg, genero, data_nascimento, estado_civil, profissao, nacionalidade, telefone, celular, whatsapp, email, observacoes, rua, numero, complemento, bairro, cidade, uf, cep) " +
                $"VALUES ('{client.Nome}', '{(client.Situacao ? 1 : 0)}', '{client.CPF}', '{client.RG}', '{client.Genero}', '{client.DataNasc}', '{client.EstadoCivil}', '{client.Profissao}', '{client.Nacionalidade}', '{client.Telefone}', '{client.Celular}', '{(client.Whatsapp ? 1 : 0)}', '{client.Email}', '{client.Obs}', " +
                $"'{client.Rua}', '{client.Numero}', '{client.Complemento}', '{client.Bairro}', '{client.Cidade}', '{client.Uf}', '{client.CEP}')", connection);

            try {
                await command.ExecuteNonQueryAsync();
                return true;
            } catch (Exception ex) {
                new Alert("Cliente", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        static public async Task<bool> UpdateClient(Clients client) {
            MySqlConnection connection = await Database.GetConnectionAsync(true);

            string updateQuery = $"UPDATE clientes SET nome = '{client.Nome}', situacao = '{(client.Situacao ? 1 : 0)}', cpf = '{client.CPF}', rg = '{client.RG}', genero = '{client.Genero}', data_nascimento = '{client.DataNasc}', estado_civil = '{client.EstadoCivil}', profissao = '{client.Profissao}', nacionalidade = '{client.Nacionalidade}', telefone = '{client.Telefone}', celular = '{client.Celular}', whatsapp = '{(client.Whatsapp ? 1 : 0)}', email = '{client.Email}', observacoes = '{client.Obs}', rua = '{client.Rua}', numero = '{client.Numero}', complemento = '{client.Complemento}', bairro = '{client.Bairro}', cidade = '{client.Cidade}', uf = '{client.Uf}', cep = '{client.CEP}'";
            updateQuery += $" WHERE codigo_cliente = {client.CodigoClient}";

            MySqlCommand command = new MySqlCommand(updateQuery, connection);

            try {
                await command.ExecuteNonQueryAsync();
                return true;
            } catch (Exception ex) {
                new Alert("Cliente", ex.Message).ShowDialog();
                return false;
            } finally {
                connection.Close();
            }
        }

        #endregion
    }
}