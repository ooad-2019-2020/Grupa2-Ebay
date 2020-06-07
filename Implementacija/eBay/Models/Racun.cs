using eBay.Models.Korisnici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace eBay.Models
{
    public class Racun
    {
        [ScaffoldColumn(false)]
        public int RacunId { get; set; }
        public string KupacId { get; set; }
        public Kupac Kupac { get; set; }
        public ICollection<StavkaRacuna> Proizvodi;
        public DateTime DatumNarucivanja { get; set; }

        public decimal Cijena() {
            var result = Proizvodi.Sum(p => p.Kolicina * p.Cijena); 
            return result;
        }
        
    }
}
