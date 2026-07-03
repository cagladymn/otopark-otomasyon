using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otoparksistemi
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        VT n1 = new VT();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand s = new SqlCommand("Select * from AracGirisi", n1.SQLbaglan());
            SqlDataReader oku = s.ExecuteReader();
            DataList1.DataSource = oku;
            DataList1.DataBind();

        }
    }
}