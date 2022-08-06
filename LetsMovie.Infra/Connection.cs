using System.Data;
using System.Data.SqlClient;

namespace LetsMovie.Infra
{
    public class Connection
    {
        SqlConnection conn = new SqlConnection();
        public Connection()
        {
            conn.ConnectionString = @"Data Source=vps40251.publiccloud.com.br;Initial Catalog=LestMovie;User ID=nathan.lubawski;Password=kaliCat18$";
           //conn.ConnectionString = @"Data Source=vps40251.publiccloud.com.br;Initial Catalog=LestMovie;Persist Security Info=True;User ID=thayssa.souza;Password=Th@y55@4";
        }

        public SqlConnection connect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open
                ();
            }
            return conn;
        }

        public void disconnect()
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
    }

}