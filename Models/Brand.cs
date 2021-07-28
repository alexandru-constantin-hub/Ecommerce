using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop1.Models
{
    public class Brand
    {
        public int BrandId { get; set; }

        public string Name { get; set; }

        public List<ModelProduct> ModelProducts { get; set; }

    }
}
