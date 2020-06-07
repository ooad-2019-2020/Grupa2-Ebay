using eBay.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBay.Models.Korisnici
{
    public class Prodavac : eBayUser
    {
        [PersonalData]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Recenzija { get; set; }
    }
}
