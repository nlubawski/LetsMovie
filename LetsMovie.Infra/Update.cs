using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Infra
{

        public class Update
        {
            Connection conn = new Connection();
            SqlCommand cmd = new SqlCommand();
            string title, newTitle;
            public Update()
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do filme que deseja atualizar o Titulo: ");
                title = Console.ReadLine();
                Console.WriteLine("Digite o novo titulo: ");
                newTitle = Console.ReadLine();

                cmd.CommandText = "EXEC spUpdateTitleMovie @title, @newTitle";
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
