using System.Data.SqlClient;

namespace LetsMovie.Infra
{
    public class DeleteDocumentary
    {
    
            Connection conn = new Connection();
            SqlCommand cmd = new SqlCommand();
            string title;
            public DeleteDocumentary()
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do Documentario que deseja Deletar: ");
                title = Console.ReadLine();
                cmd.CommandText = "EXEC spDeleteDocumentary @title";
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