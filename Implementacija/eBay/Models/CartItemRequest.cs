using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBay.Models
{
    public class CartItemRequest
    {
        public int ProizvodId { get; set; }
        public uint Kolicina { get; set; }
    }
}
