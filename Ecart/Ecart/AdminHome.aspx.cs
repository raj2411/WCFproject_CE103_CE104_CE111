using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Ecart.CanteenService;

namespace Ecart
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindData();

            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            CanteenService.IitemServiceClient it = new CanteenService.IitemServiceClient("BasicHttpBinding_IitemService");
            Item p = new Item();
            int ID = (int)e.Keys["id"];
            string name = (string)e.NewValues["Name"];
            string quantity = (string)e.NewValues["Description"];
            string status = (string)e.NewValues["status"];
            string cb = (string)e.NewValues["Category"];
            int price = int.Parse((string)e.NewValues["price"]);
            p.id = ID;
            p.Name = name;
            p.Description = quantity;
            p.price = price;
            p.status = status;
            p.Category = cb;
            it.UpdateItem(p);
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            CanteenService.IitemServiceClient pr = new CanteenService.IitemServiceClient("BasicHttpBinding_IitemService");

            int ID = (int)e.Keys["id"];
            pr.RemoveItem(ID);
            // Delete here the database record for the selected patientID
            BindData();
        }




        private void BindData()
        {
            CanteenService.IitemServiceClient item = new CanteenService.IitemServiceClient("BasicHttpBinding_IitemService");
            CanteenService.IorderServiceClient or = new CanteenService.IorderServiceClient("BasicHttpBinding_IorderService");
            DataSet li = item.GetItem();
            DataSet oi = or.GetAllOrderHistory();
            GridView1.DataSource = li;
            GridView1.DataBind();
            GridView2.DataSource = oi;
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("additems.aspx");
        }
    }
}