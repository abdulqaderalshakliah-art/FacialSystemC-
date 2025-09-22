using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DBconnection
    {

       public string conn = @"Data Source=DESKTOP-POL7I1U\SQLEXPRESS;Initial Catalog=facialSystem;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        internal DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        internal DataTable ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }

        internal SqlConnection GetConnection()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
