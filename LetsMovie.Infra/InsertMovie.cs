using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LetsMovie.Infra
{
    public class InsertMovie
    {
        Connection conn = new Connection();
        SqlCommand cmd = new SqlCommand();
        public InsertMovie(string title, string gender, DateTime dateOfRelease, string actor, string role)
        {
            cmd.CommandText = "INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES (@title, @gender, @dateOfRelease)" +
                " INSERT INTO PrincipalActor(Name) VALUES(@actor) INSERT INTO Act(Role) VALUES(@role) " +
                "EXEC spInsertAct @role, @title, @actor;";
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dateOfRelease", dateOfRelease);
            cmd.Parameters.AddWithValue("@actor", actor);
            cmd.Parameters.AddWithValue("@role", role);

            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                Console.WriteLine("Cadastrado no movies com sucesso.");

            }
            catch (SqlException erro)
            {
                Console.WriteLine($"Erro ao tentar se conectar com a tabela movies banco de dados {erro}");

            }

        }

    }
}
