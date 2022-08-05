using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Infra
{
    public class ConsultSerie
    {

        SqlDataAdapter adapter = new SqlDataAdapter();

        Connection conn = new Connection();
        SqlCommand cmd = new SqlCommand();
        string strSQL = "SELECT * FROM Serie WHERE Title LIKE @titulo";

        string consult;

        public ConsultSerie()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome da série a consultar...");
            consult = Console.ReadLine();
            try
            {
                //ligacao entre comando e conexao                
                Console.WriteLine("\nAbrindo conexão... \n");
                cmd.Connection = conn.connect();
                //passa a string pro comando que sera executado
                cmd.CommandText = strSQL;

                //aqui o comando e´ executado
                cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = $"%{consult}%";
                cmd.ExecuteNonQuery();

                if (consult == string.Empty)
                {
                    Console.WriteLine("Digite um título válido.");
                    Console.ReadKey();
                }

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    throw new Exception("Título não encontrado.");
                    Console.ReadKey();
                }

                do
                {
                    int count = reader.FieldCount;
                    while (reader.Read())
                    {
                        for (int i = 0; i < count; i++)
                        {

                            Console.WriteLine($"{reader.GetName(i)} : {reader.GetValue(i)}");

                        }
                        Console.WriteLine("\n");
                    }


                } while (reader.NextResult()); //vai pra proxima linha
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na conexão: {ex.Message}");
                Console.ReadKey();
            }
            finally
            {

                conn.disconnect();
                Console.WriteLine("Fechando conexão.");
                Console.ReadKey();
            }
        }



    }
}
