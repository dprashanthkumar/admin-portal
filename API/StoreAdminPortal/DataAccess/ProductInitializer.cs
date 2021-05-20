using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreAdminPortal.Controllers.Models;

namespace StoreAdminPortal.DataAccess
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
            new Product{name = "Play Station 4", price = 400},
            new Product{name = "Play Station 3", price = 300},
            new Product{name = "Play Station 5", price = 500},
            new Product{name = "Play Station 2", price = 200},
            new Product{name = "Play Station", price = 100},
};

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
           
            var orders = new List<Order>
            {
            new Order{orderNumber=1050,product= { name = "Play Station 3", price = 300}, quantity = 1,},
            new Order{orderNumber=1051,product= { name = "Play Station 5", price = 1500}, quantity = 3,},
            new Order{orderNumber=1052,product= { name = "Play Station 2", price = 400}, quantity = 2,},

            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
           
        }

    }
}


