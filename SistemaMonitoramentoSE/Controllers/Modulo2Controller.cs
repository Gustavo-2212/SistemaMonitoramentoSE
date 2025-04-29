using MySql.Data.MySqlClient;
using SistemaMonitoramentoSE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoSE.Controllers
{
    class Modulo2Controller
    {
        public static List<Modulo2Model> GetAll()
        {
            List<Modulo2Model> modules = new List<Modulo2Model>();

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return modules;

                connection.Open();
                string query = "";

                try
                {
                    query = "SELECT * FROM tb_module2;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        modules.Add(new Modulo2Model(
                            result.GetInt32("module_id"),
                            result.GetInt32("module1_id"),
                            result.GetString("mac_address"),
                            result.GetDateTime("_timestamp")
                        ));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao executar o comando {query}. Erro: {e.Message}");
                    return modules;
                }
                finally
                {
                    connection.Close();
                }

            }

            return modules;
        }

        public static Modulo2Model GetById(int module_id)
        {
            Modulo2Model module = null;

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return module;
                connection.Open();

                string query = "";
                try
                {
                    query = "SELECT * FROM tb_module2 WHERE module_id = @id;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", module_id);
                    MySqlDataReader result = command.ExecuteReader();

                    if (result.Read())
                    {
                        module = new Modulo2Model(
                            result.GetInt32("module_id"),
                            result.GetInt32("module1_id"),
                            result.GetString("mac_address"),
                            result.GetDateTime("_timestamp")
                        );
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao executar a query: {query}. Erro: {e.Message}");
                    return module;
                }
                finally { connection.Close(); }

                return module;
            }
        }

        public static bool Create(Modulo2Model module)
        {
            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return false;
                connection.Open();
                string query = "";

                try
                {
                    if (GetById(module.module_id) != null) return false; // Este módulo já existe

                    query = "INSERT INTO tb_module2 (module_id, module1_id, mac_address, _timestamp) VALUES (@id, @module1_id, @mac_address, @timestamp);";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", module.module_id);
                    command.Parameters.AddWithValue("@module1_id", module.module1_id);
                    command.Parameters.AddWithValue("@mac_address", module.mac_address);
                    command.Parameters.AddWithValue("@timestamp", module.timestamp);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao executar a query: {query}. Erro: {e.Message}");
                    return false;
                }
                finally { connection.Close(); }
            }
        }

        public static bool Update(Modulo2Model module, int module_id)
        {
            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return false;
                connection.Open();
                string query = "";

                try
                {
                    query = $"UPDATE tb_module2 SET @module1_id = @module1_id, mac_address = @mac_address, _timestamp = @timestamp WHERE module_id = {module_id}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@module1_id", module.module1_id);
                    command.Parameters.AddWithValue("@mac_address", module.mac_address);
                    command.Parameters.AddWithValue("@timestamp", module.timestamp);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao executar a query: {query}. Erro: {e.Message}");
                    return false;
                }
                finally { connection.Close(); }
            }
        }

        public static bool Delete(int module_id)
        {
            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return false;
                connection.Open();
                string query = "";

                try
                {
                    query = $"DELETE FROM tb_module2 WHERE module_id = {module_id}";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao executar a query: {query}. Erro: {e.Message}");
                    return false;
                }
                finally { connection.Close(); }
            }
        }

    }
}
