using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CanteenFoodService
{
    public class ItemContext : DbContext
    {

        public DbSet<Item> items { get; set; }
        public ItemContext() : base("itemsCS")
        {

        }
    }
}