using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CanteenFoodService
{
    public class OrderContext : DbContext
    {

        public DbSet<Order> orders { get; set; }
        public OrderContext() : base("itemsCS")
        {

        }
    }
}