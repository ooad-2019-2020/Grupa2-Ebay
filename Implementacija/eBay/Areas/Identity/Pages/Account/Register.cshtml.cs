using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using eBay.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using eBay.Models.Korisnici;

namespace eBay.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<eBayUser> _signInManager;
        private readonly UserManager<eBayUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<eBayUser> userManager,
            SignInManager<eBayUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

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

            [Display(Name = "Datum Rodjenja")]
            [DataType(DataType.Date)]
            public DateTime DatumRodjenja { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            [Display(Name = "Tip korisnika")]
            [DataType(DataType.Text)]
            [Required]
            public string TipKorisnika { get; set; }
        }
        public string[] Tipovi = { "Kupac", "Prodavac" };

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                eBayUser korisnik = null;
                if(Input.TipKorisnika.Equals("Kupac"))
                {
                    korisnik = new Kupac
                    {
                        UserName = Input.Email,
                        Email = Input.Email,
                        Ime = Input.Ime,
                        Prezime = Input.Prezime,
                        Adresa = Input.Adresa,
                        DatumRodjenja = Input.DatumRodjenja,
                        PhoneNumber = Input.PhoneNumber
                    };
                }
                else if (Input.TipKorisnika.Equals("Prodavac"))
                {
                    korisnik = new Prodavac
                    {
                        UserName = Input.Email,
                        Email = Input.Email,
                        Ime = Input.Ime,
                        Prezime = Input.Prezime,
                        Adresa = Input.Adresa,
                        DatumRodjenja = Input.DatumRodjenja,
                        PhoneNumber = Input.PhoneNumber,
                        Recenzija = 0
                    };
                }

                var user = korisnik;
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, Input.TipKorisnika);
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
