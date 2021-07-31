using EShop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Order
    {
        public int orderId { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
        public int Quntity { get; set; }
        public int Status { get; set; }
        public float Total { get; set; }


    }
}
