using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otoparksistemi
{
    public partial class AracGirisSayfasi : System.Web.UI.Page
    {
        VT n1 = new VT();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into AracGirisi(Tcno,Ad,Soyad,AracTipi,AracSinifi) values(@1,@2,@3,@4,@5)", n1.SQLbaglan());
            ekle.Parameters.AddWithValue("@1", t_tcno.Text);
            ekle.Parameters.AddWithValue("@2", t_ad.Text);
            ekle.Parameters.AddWithValue("@3", t_soyad.Text);
            ekle.Parameters.AddWithValue("@4", t_aractipi.Text);
            ekle.Parameters.AddWithValue("@5", t_aracsinifi.Text);
            ekle.ExecuteNonQuery();
            n1.SQLbaglan().Close();
        }
    }
}