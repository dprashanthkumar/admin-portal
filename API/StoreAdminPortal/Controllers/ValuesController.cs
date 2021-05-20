using StoreAdminPortal.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace StoreAdminPortal.Controllers
{
    [RoutePrefix("api/products")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("GetProducts")]
        public async Task<IHttpActionResult> GetProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product()
            { name = "Z900", price = 2300 });
            products.Add(new Product()
            { name = "shubert helmet", price = 2000 });
            products.Add(new Product()
            { name = "sport gloves", price = 1800 });
            return await Task.FromResult(Ok(products));
        }

        [HttpGet]
        [Route("GetOrders")]
        public async Task<IHttpActionResult> GetOrders()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order()
            { orderNumber = 43423425, product = new Product() { name = "Z900", price = 2300 }, quantity = 2 });
            orders.Add(new Order()
            { orderNumber = 43234232, product = new Product() { name = "shubert helmet", price = 2000 }, quantity = 1 });

            await Task.Run(() => { Task.Delay(1500); });
            return await Task.FromResult(Ok(orders));
        }

        [HttpGet]
        [Route("NavMenuItems")]
        public async Task<IHttpActionResult> GetLeftNav()
        {
            string[] navItems = { "dashboard", "sales", "orders", "customers", "products", "server-side values" }; 

            return await Task.FromResult(Ok(navItems));
        }
    }
}
