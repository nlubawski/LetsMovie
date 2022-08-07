using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace LetsMovie.Infra
{
    public class UpdateSerie
    {
        Connection conn = new Connection();
        SqlCommand cmd = new SqlCommand();
        string title, newTitle;
        public UpdateSerie()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome da Série que deseja atualizar o Titulo: ");
            title = Console.ReadLine();
            Console.WriteLine("Digite o novo titulo: ");
            newTitle = Console.ReadLine();

            cmd.CommandText = "EXEC spUpdateTitleSerie @title, @newTitle";
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@newTitle", newTitle);

            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                Console.WriteLine("Atualizado com sucesso.");
                Console.ReadKey();

            }
            catch (SqlException erro)
            {
                Console.WriteLine($"Erro ao tentar Atualizar ${erro}");
                Console.ReadKey();

            }
        }
    }
}
