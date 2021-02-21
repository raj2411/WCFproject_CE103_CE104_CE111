using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecart.CanteenService;
using System.Data;

namespace Ecart
{
    public partial class additems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindData();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            CanteenService.IitemServiceClient it = new CanteenService.IitemServiceClient("BasicHttpBinding_IitemService");
            Item ito = new Item();
            ito.id = int.Parse(TextBox9.Text);
            ito.Name = TextBox1.Text;
            ito.Description = TextBox2.Text;
            ito.price = int.Parse(TextBox6.Text);
            ito.Category = TextBox7.Text;
            ito.status = TextBox8.Text;
            it.AddItem(ito);
            BindData();
        }

        private void BindData()
        {
            CanteenService.IitemServiceClient item = new CanteenService.IitemServiceClient("BasicHttpBinding_IitemService");
            DataSet li = item.GetItem();
            GridView1.DataSource = li;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }
    }
}