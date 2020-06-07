using eBay.Models.Korisnici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBay.Models
{
    public class Korpa
    {
        [ScaffoldColumn(false)]
        public int KorpaId { get; set; }
        public string KupacId { get; set; }
        public Kupac Kupac{ get; set; }
        public ICollection<Proizvod> Proizvodi { get; set; }
    }
}
