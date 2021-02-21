using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections;

namespace Ecart
{

    public partial class order : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data2.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            int totalprice = Convert.ToInt32(Session["total"].ToString());
            price.Text = totalprice.ToString();
            ArrayList al = (ArrayList)Session["selectedValues"];
            foreach (Object obj in al)
            {
                ListBox1.Items.Add((string)obj);
            }
            Label1.Text = Session["oid"].ToString();
        }
    }
}