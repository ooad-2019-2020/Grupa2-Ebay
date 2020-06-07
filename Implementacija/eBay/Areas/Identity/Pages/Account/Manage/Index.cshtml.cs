using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using eBay.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eBay.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<eBayUser> _userManager;
        private readonly SignInManager<eBayUser> _signInManager;

        public IndexModel(
            UserManager<eBayUser> userManager,
            SignInManager<eBayUser> signInManager)
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
            [Phone]
            [Display(Name = "Broj telefona")]
            public string PhoneNumber { get; set; }
            [Display(Name = "Ime")]
            [DataType(DataType.Text)]
            public string Ime { get; set; }

            [Display(Name = "Prezime")]
            [DataType(DataType.Text)]
            public string Prezime { get; set; }
            [Display(Name = "Adresa")]
            [DataType(DataType.Text)]
            public string Adresa { get; set; }

            //[Display(Name = "Recenzija")]
            //[Column(TypeName = "decimal(5, 2)")]
            //public decimal Recenzija { get; set; }
            [Display(Name = "Datum Rodjenja")]
            [DataType(DataType.Date)]
            public DateTime DatumRodjenja { get; set; }

        }

        private async Task LoadAsync(eBayUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                Ime = user.Ime,
                Prezime = user.Prezime,
                DatumRodjenja = user.DatumRodjenja,
                Adresa = user.Adresa,
                PhoneNumber = phoneNumber
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

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                }
            }
            if (Input.Ime != user.Ime)
            {
                user.Ime = Input.Ime;
            }
            if (Input.Prezime != user.Prezime)
            {
                user.Prezime = Input.Prezime;
            }
            if (Input.Adresa != user.Adresa)
            {
                user.Adresa = Input.Adresa;
            }
            if (Input.DatumRodjenja != user.DatumRodjenja)
            {
                user.DatumRodjenja = Input.DatumRodjenja;
            }
            await _userManager.UpdateAsync(user);

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
