using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string InvoiceStreet { get; set; }
        public int InvoiceStreetNumber { get; set; }
        public int  InvoiceApartmentNumber { get; set; }
        public string InvoiceZipCode { get; set; }
        public string InvoiceLocality { get; set; }
        public string InvoiceProvince { get; set; }
        public string InvoiceCountry { get; set; }
        public bool IsDelivery{ get; set; }
        public string DeliveryStreet { get; set; }
        public int DeliveryStreetNumber { get; set; }
        public int DeliveryApartmentNumber { get; set; }
        public string DeliveryZipCode { get; set; }
        public string DeliveryLocality { get; set; }
        public string DeliveryProvince { get; set; }
        public string DeliveryCountry { get; set; }


    }
}
