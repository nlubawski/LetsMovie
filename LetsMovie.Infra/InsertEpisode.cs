using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Infra
{
    public class InsertEpisode
    {
        public InsertEpisode(
             string TitleSerie
                , string TitleEpisode
                , int NumberOfEpisodeSeason
            )
        {
            Connection conn = new Connection();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC spInsertEpisode @Title, @TitleEpisode, @NumberOfEpisodeInTheSeason";
            cmd.Parameters.AddWithValue("@Title", TitleSerie);
            cmd.Parameters.AddWithValue("@TitleEpisode", TitleEpisode);
            cmd.Parameters.AddWithValue("@NumberOfEpisodeInTheSeason", NumberOfEpisodeSeason);

            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
            }
            catch (SqlException erro)
            {
                Console.WriteLine($"Erro ao tentar se conectar com a tabela movies banco de dados {erro}");
                Console.ReadKey();
            }

        }
    }
}
