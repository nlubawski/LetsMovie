using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Infra
{
    public class InsertSerie
    {
        public InsertSerie(
                string TitleSerie
                , int SeasonNumber
                , int NumberOfEpisodeSeason
                , Dictionary<int, string> episodes)
        {
            Connection conn = new Connection();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Serie (Title, Season, NumberOfEpisode) VALUES (@Title, @SeasonNumber, @NumberOfEpisodeSeason)";
            cmd.Parameters.AddWithValue("@Title", TitleSerie);
            cmd.Parameters.AddWithValue("@SeasonNumber", SeasonNumber);
            cmd.Parameters.AddWithValue("@NumberOfEpisodeSeason", NumberOfEpisodeSeason);

            foreach (KeyValuePair<int, string> entry in episodes)
            {
                cmd.CommandText = "EXEC spInsertAct @Title, @TitleEpisode, @NumberOfEpisodeInTheSeason"; 
                cmd.Parameters.AddWithValue("@TitleEpisode", entry.Value);
                cmd.Parameters.AddWithValue("@NumberOfEpisodeInTheSeason", entry.Key);
            }
            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                Console.WriteLine("Cadastrado no series com sucesso.");

            }
            catch (SqlException erro)
            {
                Console.WriteLine($"Erro ao tentar se conectar com a tabela movies banco de dados {erro}");

            }



        }

    }
}
