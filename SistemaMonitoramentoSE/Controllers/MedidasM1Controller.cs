using MySql.Data.MySqlClient;
using SistemaMonitoramentoSE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoSE.Controllers
{
    class MedidasM1Controller
    {
        public static List<MedidasM1Model> GetAll()
        {
            List<MedidasM1Model> medidas = new List<MedidasM1Model>();

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return medidas;

                connection.Open();
                string query = "";

                try
                {
                    query = "SELECT * FROM tb_medidas_m1;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        medidas.Add(new MedidasM1Model(
                            result.GetInt32("medida_id"),
                            result.GetInt32("module_id"),
                            result.GetString("fase"),
                            result.GetFloat("tensao"),
                            result.GetFloat("corrente"),
                            result.GetFloat("ang_tensao"),
                            result.GetFloat("pot_apa_va"),
                            result.GetFloat("pot_real_var"),
                            result.GetFloat("pot_real_w"),
                            result.GetFloat("fator_p"),
                            result.GetFloat("freq"),
                            result.GetDateTime("_timestamp"),
                            result.IsDBNull(result.GetOrdinal("target_vat")) ? null : result.GetString("target_vat"),
                            result.IsDBNull(result.GetOrdinal("target_phase")) ? null : result.GetString("target_phase")
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

        public static List<MedidasM1Model> GetAllByModuleId(int module_id)
        {
            List<MedidasM1Model> medidas = new List<MedidasM1Model>();

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return medidas;
                connection.Open();

                string query = "";
                try
                {
                    query = "SELECT * FROM tb_medidas_m1 WHERE module_id = @module_id;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@module_id", module_id);
                    MySqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        medidas.Add(new MedidasM1Model(
                            result.GetInt32("medida_id"),
                            result.GetInt32("module_id"),
                            result.GetString("fase"),
                            result.GetFloat("tensao"),
                            result.GetFloat("corrente"),
                            result.GetFloat("ang_tensao"),
                            result.GetFloat("pot_apa_va"),
                            result.GetFloat("pot_real_var"),
                            result.GetFloat("pot_real_w"),
                            result.GetFloat("fator_p"),
                            result.GetFloat("freq"),
                            result.GetDateTime("_timestamp"),
                            result.IsDBNull(result.GetOrdinal("target_vat")) ? null : result.GetString("target_vat"),
                            result.IsDBNull(result.GetOrdinal("target_phase")) ? null : result.GetString("target_phase")
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

        public static List<MedidasM1Model> GetAllByModuleIdAndIntervalData(int module_id, DateTime data_inicial, DateTime data_final)
        {
            List<MedidasM1Model> medidas = new List<MedidasM1Model>();

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return medidas;
                connection.Open();

                string query = "";

                try
                {
                    query = "SELECT * FROM tb_medidas_m1 WHERE module_id = @id AND (_timestamp >= @d_i AND _timestamp <= @d_f);";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", module_id);
                    command.Parameters.AddWithValue("@d_i", data_inicial.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@d_f", data_final.ToString("yyyy-MM-dd HH:mm:ss"));
                    MySqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        medidas.Add(new MedidasM1Model(
                            result.GetInt32("medida_id"),
                            result.GetInt32("module_id"),
                            result.GetString("fase"),
                            result.GetFloat("tensao"),
                            result.GetFloat("corrente"),
                            result.GetFloat("ang_tensao"),
                            result.GetFloat("pot_apa_va"),
                            result.GetFloat("pot_real_var"),
                            result.GetFloat("pot_real_w"),
                            result.GetFloat("fator_p"),
                            result.GetFloat("freq"),
                            result.GetDateTime("_timestamp"),
                            result.IsDBNull(result.GetOrdinal("target_vat")) ? null : result.GetString("target_vat"),
                            result.IsDBNull(result.GetOrdinal("target_phase")) ? null : result.GetString("target_phase")
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

        public static MedidasM1Model GetById(int medida_id)
        {
            MedidasM1Model medida = null;

            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return medida;
                connection.Open();

                string query = "";
                try
                {
                    query = "SELECT * FROM tb_medidas_m1 WHERE medida_id = @id;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", medida_id);
                    MySqlDataReader result = command.ExecuteReader();

                    if (result.Read())
                    {
                        medida = new MedidasM1Model(
                            result.GetInt32("medida_id"),
                            result.GetInt32("module_id"),
                            result.GetString("fase"),
                            result.GetFloat("tensao"),
                            result.GetFloat("corrente"),
                            result.GetFloat("ang_tensao"),
                            result.GetFloat("pot_apa_va"),
                            result.GetFloat("pot_real_var"),
                            result.GetFloat("pot_real_w"),
                            result.GetFloat("fator_p"),
                            result.GetFloat("freq"),
                            result.GetDateTime("_timestamp"),
                            result.GetString("target_vat"),
                            result.GetString("target_phase")
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

        public static bool Create(MedidasM1Model medida)
        {
            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return false;
                connection.Open();
                string query = "";

                try
                {
                    if (GetById(medida.medida_id) != null) return false; // Este módulo já existe

                    query = "INSERT INTO tb_medidas_m1 (medida_id, module_id, fase, tensao, corrente, ang_tensao, pot_apa_va, pot_real_var, pot_real_w, fator_p, freq, _timestamp, target_vat, target_phase) VALUES (@id, @module_id, @fase, @tensao, @corrente, @angTensao, @potApaVA, @potRealVAr, @potRealW, @fatorP, @freq, @timestamp, @target_vat, @target_phase);";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", medida.medida_id);
                    command.Parameters.AddWithValue("@module_id", medida.module_id);
                    command.Parameters.AddWithValue("@fase", medida.fase);
                    command.Parameters.AddWithValue("@tensao", medida.tensao);
                    command.Parameters.AddWithValue("@corrente", medida.corrente);
                    command.Parameters.AddWithValue("@angTensao", medida.angTensao);
                    command.Parameters.AddWithValue("@potApaVA", medida.potApaVA);
                    command.Parameters.AddWithValue("@potRealVAr", medida.potRealVAr);
                    command.Parameters.AddWithValue("@potRealW", medida.potRealW);
                    command.Parameters.AddWithValue("@fatorP", medida.fatorP);
                    command.Parameters.AddWithValue("@freq", medida.freq);
                    command.Parameters.AddWithValue("@timestamp", medida.timestamp);
                    command.Parameters.AddWithValue("@target_vat", medida.target_vat);
                    command.Parameters.AddWithValue("@target_phase", medida.target_phase);

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

        public static bool Update(MedidasM1Model medida, int medida_id)
        {
            using (var connection = DBConnection.GetConnection())
            {
                if (connection == null) return false;
                connection.Open();
                string query = "";

                try
                {
                    query = $"UPDATE tb_medidas_m1 SET fase = @fase, tensao = @tensao, corrente = @corrente, ang_tensao = @angTensao, pot_apa_va = @pot_apa_va, pot_real_var = @potRealVAr, pot_real_w = @potRealW, fator_p = @fatorP, freq = @freq, _timestamp = @timestamp, target_vat = @target_vat, target_phase = @target_phase WHERE medida_id = {medida_id}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fase", medida.fase);
                    command.Parameters.AddWithValue("@tensao", medida.tensao);
                    command.Parameters.AddWithValue("@corrente", medida.corrente);
                    command.Parameters.AddWithValue("@angTensao", medida.angTensao);
                    command.Parameters.AddWithValue("@potApaVA", medida.potApaVA);
                    command.Parameters.AddWithValue("@potRealVAr", medida.potRealVAr);
                    command.Parameters.AddWithValue("@potRealW", medida.potRealW);
                    command.Parameters.AddWithValue("@fatorP", medida.fatorP);
                    command.Parameters.AddWithValue("@freq", medida.freq);
                    command.Parameters.AddWithValue("@timestamp", medida.timestamp);
                    command.Parameters.AddWithValue("@target_vat", medida.target_vat);
                    command.Parameters.AddWithValue("@target_phase", medida.target_phase);

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
                    query = $"DELETE FROM tb_medidas_m1 WHERE medida_id = {medida_id}";
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
