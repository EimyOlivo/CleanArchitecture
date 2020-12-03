using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Infrastructure.Repository.Commons
{
    class ConnectionDB
    {
        SqlConnection con;
        public ConnectionDB(){

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\einst\source\repos\CleanArchitecture\Infrastructure\Database1.mdf;Integrated Security=True");

        }

        public SqlConnection GetConnection() {
            return con;
        }
    }

}
