using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CanteenFoodService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IitemService,IorderService
    {
        public void AddItem(Item itemobj)
        {
            ItemContext po = new ItemContext();
            po.items.Add(itemobj);
            po.SaveChanges();
        }

        public DataSet GetAllOrderHistory()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Orders", @"data source = (localdb)\MSSQLLocalDB; initial catalog = itemsCS; integrated security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            DataSet ds = new DataSet();
            da.Fill(ds, "orders");
            return ds;
        }

        public DataSet GetItem()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Items", @"data source = (localdb)\MSSQLLocalDB; initial catalog = itemsCS; integrated security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            DataSet ds = new DataSet();
            da.Fill(ds, "items");
            return ds;
        }

        public Order GetOrderDetail(int id)
        {
            OrderContext po = new OrderContext();
            var c = (from item_ob in po.orders where item_ob.orderid == id select item_ob).First();
            return c;
        }

        public void PlaceOrder(Order orderobj)
        {
            OrderContext po = new OrderContext();
            po.orders.Add(orderobj);
            po.SaveChanges();
        }

        public void RemoveItem(int id)
        {
            ItemContext po = new ItemContext();
            var c = (from item_ob in po.items where item_ob.id == id select item_ob).First();
            po.items.Remove(c);
            po.SaveChanges();
        }

        public void UpdateItem(Item itemobj)
        {
            ItemContext po = new ItemContext();
            var c = (from item_ob in po.items where item_ob.id == itemobj.id select item_ob).First();
            c.Name = itemobj.Name;
            c.Description = itemobj.Description;
            c.Category = itemobj.Category;
            c.price = itemobj.price;
            c.status = itemobj.status;
            po.SaveChanges();
        }

        
    }
}
