using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EShop1.Models
{
        
        public class Product

        {

 //           public Product()
 //       {
 //           this.Categories = new HashSet<Category>();
 //       }

            [Key]
            public int ProductId { get; set; }

            public string Name { get; set; }

           public int ModelProductId { get; set; }
           public ModelProduct ModelProduct { get; set; }

           public int CategoryId { get; set; }
            public Category Category { get; set; }

        public string Size { get; set; }

            public string Description { get; set; }

          
            public string BarCode { get; set; }

            public string Code { get; set; }

            public float PriceReceived { get; set; }


            public DateTime EntryDate { get; set; }

            public int Quantiy { get; set; }

            public string ImageLink { get; set; }

  //          public virtual ICollection<Category> Categories { get; set; }
            public List<SellPrice> SellPrices { get; set; }





    }
}

