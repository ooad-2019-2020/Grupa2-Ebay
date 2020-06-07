using eBay.Models.Korisnici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBay.Models
{
    public class Proizvod
    {
        [ScaffoldColumn(false)]
        public int ProizvodId { get; set; }
        [Required]
        public String Naziv { get; set; }
        [Required]
        [Display(Name ="Opis proizvoda")]
        public String OpisProizvoda { get; set; }
        
        [Column(TypeName = "decimal(5, 2)")] // Tip kakav ce bit u bazi. Mora se staviti preciznost. Inace se prikazuje warning
        public decimal Cijena { get; set; }

        [Required]
        [Display(Name = "Slika")]
        public String URLSlike { get; set; }

        public int KategorijaId { get; set; }
        
        public Kategorija Kategorija { get; set; }

        public int ProdavacId { get; set; }

        public Prodavac Prodavac { get; set; }


        public uint Kolicina { get; set; }

        public Proizvod clone() {
            return new Proizvod
            {
                ProizvodId = this.ProizvodId,
                Naziv = this.Naziv,
                OpisProizvoda = this.OpisProizvoda,
                Cijena = this.Cijena,
                URLSlike = this.URLSlike,
                KategorijaId = this.KategorijaId,
                Kategorija = this.Kategorija,
                ProdavacId = this.ProdavacId,
                Prodavac = this.Prodavac
            };   
        }
    }
}
