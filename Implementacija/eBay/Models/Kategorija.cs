using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBay.Models
{
    public class Kategorija
    {
        [ScaffoldColumn(false)]
        public int KategorijaId { get; set; }
        [Required]
        public String Naziv { get; set; }
    }
}
