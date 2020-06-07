using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBay.Models
{
    public class StavkaKorpe
    {
        public int StavkaKorpeId { get; set; }
        public int ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }
        public uint Kolicina { get; set; }
    }
}
