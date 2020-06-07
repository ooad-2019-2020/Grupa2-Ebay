using eBay.Models.Korisnici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBay.Models
{
    public class Racun
    {
        public Kupac Kupac { get; set; }
        public ICollection<StavkaRacuna> Proizvodi;
        public DateTime DatumNarucivanja { get; set; }

        public decimal Cijena() {
            var result = Proizvodi.Sum(p => p.Kolicina * p.Cijena); 
            return result;
        }
        
    }
}
