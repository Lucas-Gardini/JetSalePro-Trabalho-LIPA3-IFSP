using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetSalePro.services {
    public class Database {
        public static async Task<bool> CreateDatabase() {
            // Função auxiliar que retorna uma conexão com o banco de dados
            MySqlConnection connection = await GetConnectionAsync(false);

            try {
                // Criando o banco de dados
                string script = File.ReadAllText(Application.StartupPath + "/assets" + "/database.sql");

                // Gerando o comando SQL e executando-o
                MySqlCommand command = new MySqlCommand(script, connection);
                await command.ExecuteNonQueryAsync();

                return true;
            } catch (Exception ex) {
                MessageBox.Show("Erro ao iniciar o banco de dados\n" + ex.Message);
                Application.Exit();
            } finally { connection.Close(); }

            return true;
        }

        public static async Task<MySqlConnection> GetConnectionAsync(bool useDefaultDatabase = false) {
            // Cria uma conexão, obtendo a string de conexão do arquivo de configuração do projeto
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings[useDefaultDatabase ? "JetSalePro" : "MySql"].ConnectionString);

            try {
                await connection.OpenAsync();
                return connection;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
