using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace otoparksistemi
{
    public class VT
    {
        public SqlConnection SQLbaglan()
        {
            SqlConnection b1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=otoparksistemi;Integrated Security=true");
            b1.Open();
            return b1;


        }
    }
}