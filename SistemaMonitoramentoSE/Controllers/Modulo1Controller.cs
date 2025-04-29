using MySql.Data.MySqlClient;
using SistemaMonitoramentoSE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoSE.Controllers
{
    class Modulo1Controller
    {
        public static List<Modulo1Model> GetAll()
        {
            List<Modulo1Model> modules = new List<Modulo1Model>();

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return modules;

                connection.Open();
                string query = "";

                try
                {
                    query = "SELECT * FROM tb_module1;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        modules.Add(new Modulo1Model(
                            result.GetInt32("module_id"),
                            result.GetString("mac_address"),
                            result.GetInt32("num_packages"),
                            result.GetDateTime("_timestamp"),
                            result.GetInt32("send_freq_ms")
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

        public static Modulo1Model GetById(int module_id)
        {
            Modulo1Model module = null;

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return module;
                connection.Open();

                string query = "";
                try
                {
                    query = "SELECT * FROM tb_module1 WHERE module_id = @id;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", module_id);
                    MySqlDataReader result = command.ExecuteReader();

                    if (result.Read())
                    {
                        module = new Modulo1Model(
                            result.GetInt32("module_id"),
                            result.GetString("mac_address"),
                            result.GetInt32("num_packages"),
                            result.GetDateTime("_timestamp"),
                            result.GetInt32("send_freq_ms")
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

        public static bool Create(Modulo1Model module)
        {
            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return false;
                connection.Open();
                string query = "";

                try
                {
                    if (GetById(module.module_id) != null) return false; // Este módulo já existe

                    query = "INSERT INTO tb_module1 (module_id, mac_address, num_packages, _timestamp, send_freq_ms) VALUES (@id, @mac_address, @num_packages, @timestamp, @send_freq_ms);";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", module.module_id);
                    command.Parameters.AddWithValue("@mac_address", module.mac_address);
                    command.Parameters.AddWithValue("@num_packages", module.num_packages);
                    command.Parameters.AddWithValue("@timestamp", module.timestamp);
                    command.Parameters.AddWithValue("@send_freq_ms", module.send_freq_ms);

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

        public static bool Update(Modulo1Model module, int module_id)
        {
            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return false;
                connection.Open();
                string query = "";

                try
                {
                    query = $"UPDATE tb_module1 SET mac_address = @mac_address, num_packages = @num_packages, _timestamp = @timestamp, send_freq_ms = @send_freq_ms WHERE module_id = {module_id}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@mac_address", module.mac_address);
                    command.Parameters.AddWithValue("@num_packages", module.num_packages);
                    command.Parameters.AddWithValue("@timestamp", module.timestamp);
                    command.Parameters.AddWithValue("@send_freq_ms", module.send_freq_ms);

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
                    query = $"DELETE FROM tb_module1 WHERE module_id = {module_id}";
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
