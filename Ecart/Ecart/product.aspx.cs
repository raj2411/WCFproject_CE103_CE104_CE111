using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Windows.Forms;
using Ecart.CanteenService;

namespace Ecart
{
    public partial class product : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data2.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page.IsPostBack))
            {
                CanteenService.IitemServiceClient item = new CanteenService.IitemServiceClient("BasicHttpBinding_IitemService");
                DataSet li = item.GetItem();
                ListBox1.DataSource = li.Tables[0].DefaultView;
                ListBox1.DataTextField = "Name";
                ListBox1.DataValueField = "price";
                ListBox1.DataBind();
                disp_data();
            }
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string b = ListBox1.SelectedItem.ToString();
            string a = ListBox1.SelectedValue.ToString();
            odered.Items.Add(new ListItem(b, a));
            int n = Convert.ToInt32(a);
            myglobal.total = myglobal.total + n;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string userf = Session["new"].ToString();
            Random rand = new Random((int)DateTime.Now.Ticks);
            int uniqueorderNumber;
            uniqueorderNumber = rand.Next(100000, 999999);
            Session["total"] = myglobal.total;
            ArrayList al = new ArrayList();
            string itemlist = "";
            for (int i = 0; i < odered.Items.Count; i++)
            {
                al.Add(odered.Items[i].Text);
                itemlist += odered.Items[i].Text + "|";
            }
            Session["selectedValues"] = al;
            Session["oid"] = uniqueorderNumber;
            CanteenService.IorderServiceClient or = new CanteenService.IorderServiceClient("BasicHttpBinding_IorderService");
            Order o = new Order();
            o.orderid = uniqueorderNumber;
            o.ItemName = itemlist;
            o.PersonName = userf;
            o.Amount = myglobal.total;
            o.Comments = "no comments";
            o.status = "ordered";
            or.PlaceOrder(o);
            Response.Redirect("order.aspx");
        }

        public void disp_data()
        {
            CanteenService.IitemServiceClient item = new CanteenService.IitemServiceClient("BasicHttpBinding_IitemService");
            DataSet li = item.GetItem();
            GridView1.DataSource = li;
            GridView1.DataBind();
            conn.Close();
        }


        public static class myglobal
        {
            public static int total;
        }
    }
}