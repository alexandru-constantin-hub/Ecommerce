using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ecommerce.Areas.Identity.Pages.Account.Manage
{
    public partial class AddressModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AddressModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string InvoiceStreet { get; set; }
            public int InvoiceStreetNumber { get; set; }
            public int InvoiceApartmentNumber { get; set; }
            public string InvoiceZipCode { get; set; }
            public string InvoiceLocality { get; set; }
            public string InvoiceProvince { get; set; }
            public string InvoiceCountry { get; set; }
            public bool IsDelivery { get; set; }
            public string DeliveryStreet { get; set; }
            public int DeliveryStreetNumber { get; set; }
            public int DeliveryApartmentNumber { get; set; }
            public string DeliveryZipCode { get; set; }
            public string DeliveryLocality { get; set; }
            public string DeliveryProvince { get; set; }
            public string DeliveryCountry { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var invoiceStreet = user.InvoiceStreet;
            var invoiceStreetNumber = user.InvoiceStreetNumber;
            var invoiceApartmentNumber = user.InvoiceApartmentNumber;
            var invoiceZipCode = user.InvoiceZipCode;
            var invoiceLocality = user.InvoiceLocality;
            var invoiceProvince = user.InvoiceProvince;
            var invoiceCountry = user.InvoiceCountry;
            var isDelivery = user.IsDelivery;
            var deliveryStreet = user.DeliveryStreet;
            var deliveryStreetNumber = user.DeliveryStreetNumber;
            var deliveryApartmentNumber = user.DeliveryApartmentNumber;
            var deliveryZipCode = user.DeliveryZipCode;
            var deliveryLocality = user.DeliveryLocality;
            var deliveryProvince = user.DeliveryProvince;
            var deliveryCountry = user.DeliveryCountry;


            Input = new InputModel
            {
                InvoiceStreet = invoiceStreet,
                InvoiceStreetNumber = invoiceStreetNumber,
                InvoiceApartmentNumber = invoiceApartmentNumber,
                InvoiceZipCode = invoiceZipCode,
                InvoiceLocality = invoiceLocality,
                InvoiceProvince = invoiceProvince,
                InvoiceCountry = invoiceCountry,
                IsDelivery = isDelivery,
                DeliveryStreet = deliveryStreet,
                DeliveryStreetNumber = deliveryStreetNumber,
                DeliveryApartmentNumber = deliveryApartmentNumber,
                DeliveryZipCode = deliveryZipCode,
                DeliveryLocality = deliveryLocality,
                DeliveryProvince = deliveryProvince,
                DeliveryCountry = deliveryCountry
        };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var invoiceStreet = user.InvoiceStreet;
            if (Input.InvoiceStreet != invoiceStreet)
            {
                user.InvoiceStreet = Input.InvoiceStreet;
                await _userManager.UpdateAsync(user);
            }

            var invoiceStreetNumber = user.InvoiceStreetNumber;
            if (Input.InvoiceStreetNumber != invoiceStreetNumber)
            {
                user.InvoiceStreetNumber = Input.InvoiceStreetNumber;
                await _userManager.UpdateAsync(user);
            }

            var invoiceApartmentNumber = user.InvoiceApartmentNumber;
            if (Input.InvoiceApartmentNumber != invoiceApartmentNumber)
            {
                user.InvoiceApartmentNumber = Input.InvoiceApartmentNumber;
                await _userManager.UpdateAsync(user);
            }

            var invoiceZipCode = user.InvoiceZipCode;
            if (Input.InvoiceZipCode != invoiceZipCode)
            {
                user.InvoiceZipCode = Input.InvoiceZipCode;
                await _userManager.UpdateAsync(user);
            }

            var invoiceLocality = user.InvoiceLocality;
            if (Input.InvoiceLocality != invoiceLocality)
            {
                user.InvoiceLocality = Input.InvoiceLocality;
                await _userManager.UpdateAsync(user);
            }

            var invoiceProvince = user.InvoiceProvince;
            if (Input.InvoiceProvince != invoiceProvince)
            {
                user.InvoiceProvince = Input.InvoiceProvince;
                await _userManager.UpdateAsync(user);
            }

            var invoiceCountry = user.InvoiceCountry;
            if (Input.InvoiceCountry != invoiceCountry)
            {
                user.InvoiceCountry = Input.InvoiceCountry;
                await _userManager.UpdateAsync(user);
            }

            var isDelivery = user.IsDelivery;
            if (Input.IsDelivery != isDelivery)
            {
                user.InvoiceCountry = Input.InvoiceCountry;
                await _userManager.UpdateAsync(user);
            }

            var deliveryStreet = user.DeliveryStreet;
            if (Input.DeliveryStreet != deliveryStreet)
            {
                user.DeliveryStreet = Input.DeliveryStreet;
                await _userManager.UpdateAsync(user);
            }

            var deliveryStreetNumber = user.DeliveryStreetNumber;
            if (Input.DeliveryStreetNumber != deliveryStreetNumber)
            {
                user.DeliveryStreetNumber = Input.DeliveryStreetNumber;
                await _userManager.UpdateAsync(user);
            }

            var deliveryApartmentNumber = user.DeliveryApartmentNumber;
            if (Input.DeliveryApartmentNumber != deliveryApartmentNumber)
            {
                user.DeliveryApartmentNumber = Input.DeliveryApartmentNumber;
                await _userManager.UpdateAsync(user);
            }

            var deliveryZipCode = user.DeliveryZipCode;
            if (Input.DeliveryZipCode != deliveryZipCode)
            {
                user.DeliveryZipCode = Input.DeliveryZipCode;
                await _userManager.UpdateAsync(user);
            }

            var deliveryLocality = user.DeliveryLocality;
            if (Input.DeliveryLocality != deliveryLocality)
            {
                user.DeliveryLocality = Input.DeliveryLocality;
                await _userManager.UpdateAsync(user);
            }

            var deliveryProvince = user.DeliveryProvince;
            if (Input.DeliveryProvince != deliveryProvince)
            {
                user.DeliveryProvince = Input.DeliveryProvince;
                await _userManager.UpdateAsync(user);
            }

            var deliveryCountry = user.DeliveryCountry;
            if (Input.DeliveryCountry != deliveryCountry)
            {
                user.DeliveryCountry = Input.DeliveryCountry;
                await _userManager.UpdateAsync(user);
            }


            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
