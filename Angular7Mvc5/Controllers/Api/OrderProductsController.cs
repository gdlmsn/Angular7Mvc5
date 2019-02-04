using Angular7Mvc5.Controllers.Core;
using Angular7Mvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular7Mvc5.Controllers.Api
{
    public class OrderProductsController : ApiController
    {
        private List<OrderProducts> OrderProducts { get; set; }

        public OrderProductsController()
        {
            //reload all the data first in ordr to keep all data updated.
            SystemController.Instance.LoadData();
            //assign data
            OrderProducts = SystemController.Instance.OrderProducts;
        }

        // GET: api/OrderProducts
        public IEnumerable<OrderProducts> Get()
        {
            return OrderProducts;
        }

        // GET: api/OrderProducts/5
        public OrderProducts Get(int id)
        {
            return OrderProducts.FirstOrDefault(i => i.OrderId == id);
        }
    }
}
