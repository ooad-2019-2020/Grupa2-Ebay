using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eBay.Data;
using eBay.Models;
using eBay.Models.Korisnici;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace eBay.Controllers
{
    public class KorpaController : Controller
    {
        private readonly eBayContext _context;

        public KorpaController(eBayContext context)
        {
            _context = context;
        }

        // GET: Korpa
        public IActionResult Index()
        {
            if (User.IsInRole("Kupac"))
            {
                Kupac kupac = _context.Kupci.Where(k => k.UserName == User.Identity.Name).FirstOrDefault();
                var lista = _context.Korpe.Where(k => k.KupacId == kupac.Id).Include(korpa=>korpa.Proizvodi).ThenInclude(p=>p.Proizvod).ToList();
                Korpa korpa = null;
                if (lista.Count == 0)
                {
                    korpa = new Korpa { KupacId = kupac.Id, Proizvodi = new StavkaKorpe[]{ }, Kupac = kupac };
                    korpa = _context.Korpe.Add(korpa).Entity;
                } else
                {
                    korpa = lista[0];
                }
 
                return View(korpa);
            }
            return RedirectToRoute("/login");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart([FromBody] StavkaRequest request)
        {
            StavkaKorpe stavka = _context.StavkeKorpe.Where(stavka => stavka.StavkaKorpeId == request.StavkaKorpeId).First();
            _context.StavkeKorpe.Remove(stavka);
            await _context.SaveChangesAsync();
            return Json(new object{});
        }

    }
}
