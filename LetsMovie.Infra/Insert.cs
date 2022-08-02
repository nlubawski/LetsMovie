using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LetsMovie.Infra
{
    public class Insert
    {
        Connection conn = new Connection();
        SqlCommand cmd = new SqlCommand();
        public Insert(string title, string gender, DateTime dateOfRelease, string actor, string role)
        {
            cmd.CommandText = "INSERT INTO Movie (Title, Gender, DateOfRelease) VALUES (@title, @gender, @dateOfRelease)";
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dateOfRelease", dateOfRelease);
            try
            {
                //conectar com o banco
                cmd.Connection = conn.connect();

                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conn.disconnect();
                Console.WriteLine("Cadastrado com sucesso.");

            }
            catch (SqlException erro)
            {
                Console.WriteLine("Erro ao tentar se conectar com o banco de dados");

            }
        }

    }
}
