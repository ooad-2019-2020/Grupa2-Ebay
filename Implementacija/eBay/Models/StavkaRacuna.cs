using eBay.Models.Korisnici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBay.Models
{
    public class StavkaRacuna
    {
        [ScaffoldColumn(false)]
        public int StavkaRacunaId{ get; set; }
        public String Naziv { get; set; }
        [Display(Name = "Opis proizvoda")]
        public String OpisProizvoda { get; set; }

        [Column(TypeName = "decimal(5, 2)")] // Tip kakav ce bit u bazi. Mora se staviti preciznost. Inace se prikazuje warning
        public decimal Cijena { get; set; }

        public String Kategorija { get; set; }

        public int ProdavacId { get; set; }

        public Prodavac Prodavac { get; set; }

        [Required]
        public uint Kolicina { get; set; }
        public int ProizvodId { get; set; }
    }
}
