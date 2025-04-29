using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoSE
{
    class DBConnection
    {

        public static MySqlConnection GetConnection()
        {
            string connection_string = "server=localhost;database=db_sistema_monitoramento_se;user=gustavo;password=1234;";
            try
            {
                var connection = new MySqlConnection(connection_string);
                if (connection == null)
                {
                    Console.WriteLine("Conexão bem-sucedida!");
                    return connection;
                }
                return new MySqlConnection(connection_string);
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Erro ao conectar ao banco de dados: {e.Message}");
                return null;
            }
        }
    }
}
