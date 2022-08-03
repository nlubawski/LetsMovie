using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Infra
{
    public class Delete
    {
        Connection conn = new Connection();
        SqlCommand cmd = new SqlCommand();
        string title;
        public Delete()
        {
            Console.WriteLine("Digite o nome do filme que deseja Deletar: ");
            title = Console.ReadLine();
            cmd.CommandText = "EXEC spDeleteMovieActActor @title";
            cmd.Parameters.AddWithValue("@title", title);

            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                Console.WriteLine("Deletado com sucesso.");
                Console.ReadKey();

            }
            catch (SqlException erro)
            {
                Console.WriteLine($"Erro ao tentar Deletar");

            }

        }
    }
}
