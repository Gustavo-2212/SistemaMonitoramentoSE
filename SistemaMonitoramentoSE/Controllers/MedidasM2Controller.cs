using MySql.Data.MySqlClient;
using SistemaMonitoramentoSE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoSE.Controllers
{
    class MedidasM2Controller
    {
        public static List<MedidasM2Model> GetAll()
        {
            List<MedidasM2Model> medidas = new List<MedidasM2Model>();

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return medidas;

                connection.Open();
                string query = "";

                try
                {
                    query = "SELECT * FROM tb_medidas_m2;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        medidas.Add(new MedidasM2Model(
                            result.GetInt32("medida_id"),
                            result.GetInt32("module2_id"),
                            result.GetBoolean("short_circuit"),
                            result.GetDateTime("date_init"),
                            result.GetDateTime("data_end")
                        ));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao executar o comando {query}. Erro: {e.Message}");
                    return medidas;
                }
                finally
                {
                    connection.Close();
                }

            }

            return medidas;
        }

        public static List<MedidasM2Model> GetAllByModuleId(int module2_id)
        {
            List<MedidasM2Model> medidas = new List<MedidasM2Model>();

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return medidas;
                connection.Open();

                string query = "";
                try
                {
                    query = "SELECT * FROM tb_medidas_m2 WHERE module2_id = @module2_id;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@module2_id", module2_id);
                    MySqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        medidas.Add(new MedidasM2Model(
                            result.GetInt32("medida_id"),
                            result.GetInt32("module2_id"),
                            result.GetBoolean("short_circuit"),
                            result.GetDateTime("data_init"),
                            result.GetDateTime("data_end")
                        ));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao executar a query: {query}. Erro: {e.Message}");
                    return medidas;
                }
                finally { connection.Close(); }

                return medidas;
            }
        }

       
        public static MedidasM2Model GetById(int medida_id)
        {
            MedidasM2Model medida = null;

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return medida;
                connection.Open();

                string query = "";
                try
                {
                    query = "SELECT * FROM tb_medidas_m2 WHERE medida_id = @id;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", medida_id);
                    MySqlDataReader result = command.ExecuteReader();

                    if (result.Read())
                    {
                        medida = new MedidasM2Model(
                            result.GetInt32("medida_id"),
                            result.GetInt32("module2_id"),
                            result.GetBoolean("short_circuit"),
                            result.GetDateTime("data_init"),
                            result.GetDateTime("data_end")
                        );
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao executar a query: {query}. Erro: {e.Message}");
                    return medida;
                }
                finally { connection.Close(); }

                return medida;
            }
        }

        public static bool Create(MedidasM2Model medida)
        {
            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return false;
                connection.Open();
                string query = "";

                try
                {
                    if (GetById(medida.medida_id) != null) return false; // Este módulo já existe

                    query = "INSERT INTO tb_medidas_m2 (module2_id, short_circuit, data_init, data_end) VALUES (@module2_id, @short_circuit, @data_init, @data_end);";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@module2_id", medida.module2_id);
                    command.Parameters.AddWithValue("@short_circuit", medida.short_circuit);
                    command.Parameters.AddWithValue("@data_init", medida.data_init);
                    command.Parameters.AddWithValue("@data_end", medida.data_end);

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

        public static bool Update(MedidasM2Model medida, int medida_id)
        {
            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return false;
                connection.Open();
                string query = "";

                try
                {
                    query = $"UPDATE tb_medidas_m2 SET module2_id = @module2_id, short_circuit = @short_circuit, data_init = @data_init, data_end = @data_end WHERE medida_id = {medida_id}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@module2_id", medida.module2_id);
                    command.Parameters.AddWithValue("@short_circuit", medida.short_circuit);
                    command.Parameters.AddWithValue("@data_init", medida.data_init);
                    command.Parameters.AddWithValue("@data_end", medida.data_end);

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

        public static bool Delete(int medida_id)
        {
            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return false;
                connection.Open();
                string query = "";

                try
                {
                    query = $"DELETE FROM tb_medidas_m2 WHERE medida_id = {medida_id}";
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
