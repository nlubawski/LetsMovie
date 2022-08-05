using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Infra
{
    public class InsertDocumentary
    {
        Connection conn = new Connection();
        SqlCommand cmd = new SqlCommand();
        public InsertDocumentary(string Title, string country, string producer)
        {
            cmd.CommandText = "INSERT INTO Producer (Name) VALUES (@producer)" +
                "INSERT INTO Documentary (Title, Country) VALUES (@Title, @country)" +
                "EXEC spInsertDocumentary @Title, @producer";
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@producer", producer);

            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                Console.WriteLine("\nCadastrado no documentary com sucesso.");
                Console.ReadKey();

            }
            catch (SqlException erro)
            {
                Console.WriteLine($"\nErro ao tentar se conectar com a tabela movies banco de dados {erro}");
                Console.ReadKey();
            }
        }
    }
}
