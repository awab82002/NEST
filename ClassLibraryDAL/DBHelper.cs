﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=db_nest;Integrated Security=True;TrustServerCertificate=True");

            return con;
        }
    }
}
