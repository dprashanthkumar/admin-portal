using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreAdminPortal.Controllers.Models
{
    public class Order
    {
        public int orderNumber { get; set; }
        public Product product { get; set; }
        public int quantity { get; set; }
    }
}