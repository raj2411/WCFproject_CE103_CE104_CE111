using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Ecart
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data2.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(userid.Text == "WCF@ddu.ac.in" && password.Text == "WCF")
            {
                Response.Redirect("AdminHome.aspx");
            }
            try
            {
                conn.Open();
                String cmdStr2 = "select * from userdata where emailid ='" + userid.Text + "' and  password='" + password.Text + "'";
                SqlCommand pass = new SqlCommand(cmdStr2, conn);
                SqlDataReader sdr = pass.ExecuteReader();
                if (sdr.Read())
                {
                    Session["new"] = userid.Text;
                    Response.Redirect("product.aspx");
                }
                else
                {
                    error.Visible = true;
                    error.Text = "Invalid Password Please Enter Correct Password";
                }
                conn.Close();
            }
            catch(Exception er)
            {
                Response.Write(er.Message);
            }
            disp_data();
        }

        public void disp_data()
        {
        }
    }
}