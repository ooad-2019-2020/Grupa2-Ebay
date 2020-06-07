using eBay.Models.Korisnici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBay.Models
{
    public class Korpa
    {
        public int KupacId { get; set; }
        public Kupac Kupac{ get; set; }
        public ICollection<Proizvod> Proizvodi { get; set; }
    }
}
