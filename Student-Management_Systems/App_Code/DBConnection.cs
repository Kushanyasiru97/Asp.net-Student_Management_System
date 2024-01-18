using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Student_Management_Systems.App_Code
{
    public class DBConnection
    {
        public DBConnection()
        {
        }

        public SqlConnection GetConn()
        {
            String CONNECTION_STRING = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            return con;
        }
    }
}