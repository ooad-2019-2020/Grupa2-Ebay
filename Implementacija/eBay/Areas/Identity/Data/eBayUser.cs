using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace eBay.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the eBayUser class
    public class eBayUser : IdentityUser
    {
        [PersonalData]
        public string Ime { get; set; }
        [PersonalData]
        public string Prezime { get; set; }
        [PersonalData]
        public string Adresa { get; set; }    
        [PersonalData]
        public DateTime DatumRodjenja { get; set; }
    }
}
