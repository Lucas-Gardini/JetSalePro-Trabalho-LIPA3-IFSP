﻿using JetSalePro.pages;
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
            } catch (Exception ex) {
                new Alert("Erro ao iniciar o banco de dados", ex.Message).ShowDialog();
                Application.Exit();
            } finally { connection?.Close(); }

            return true;
        }

        public static async Task<bool> InsertDefaultData() {
            // Função auxiliar que retorna uma conexão com o banco de dados
            MySqlConnection connection = await GetConnectionAsync(false);

            try {
                // Inserindo os dados padrões
                string script = File.ReadAllText(Application.StartupPath + "/assets" + "/default_data.sql");

                // Gerando o comando SQL e executando-o
                MySqlCommand command = new MySqlCommand(script, connection);
                await command.ExecuteNonQueryAsync();
            } catch (Exception ex) {
                new Alert("Erro ao inserir os dados padrão no banco de dados", ex.Message).ShowDialog();
                Application.Exit();
            } finally { connection?.Close(); }

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
