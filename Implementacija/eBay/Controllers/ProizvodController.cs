using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eBay.Models;
using Microsoft.AspNetCore.Authorization;
using eBay.Data;
using eBay.Models.Korisnici;

namespace eBay.Controllers
{
    public class ProizvodController : Controller
    {
        private readonly eBayContext _context;

        public ProizvodController(eBayContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddToCart([FromBody] CartItemRequest request) 
        {
            System.Console.WriteLine(request.Kolicina + "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Response.Headers.Add("Content-Type", "application/json");
            return Json(request);
        }

        // GET: Proizvod
        public async Task<IActionResult> Index()
        {
            return View(await _context.Proizvodi.ToListAsync());
        }

        // GET: Proizvod/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvod = await _context.Proizvodi
                .FirstOrDefaultAsync(m => m.ProizvodId == id);
            if (proizvod == null)
            {
                return NotFound();
            }

            return View(proizvod);
        }

        // GET: Proizvod/Create
        [Authorize(Roles = "Prodavac")]
        public async Task<IActionResult> Create()
        {
            var kategorije = await _context.Kategorije.ToListAsync();
            ViewBag.Kategorije = new SelectList(kategorije,"KategorijaId", "Naziv");
            return View();
        }

        // POST: Proizvod/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Prodavac")]
        public async Task<IActionResult> Create([Bind("Naziv,OpisProizvoda,Cijena,URLSlike,KategorijaId")] Proizvod proizvod)
        {
            proizvod.Prodavac = User.Identity as Prodavac;
            proizvod.Kategorija = _context.Kategorije.Where(k => k.KategorijaId == proizvod.KategorijaId).FirstOrDefault();
            if (ModelState.IsValid)
            {
                _context.Add(proizvod);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proizvod);
        }

        // GET: Proizvod/Edit/5
        [Authorize(Roles = "Prodavac")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvod = await _context.Proizvodi.FindAsync(id);
            if (proizvod == null)
            {
                return NotFound();
            }
            return View(proizvod);
        }

        // POST: Proizvod/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Prodavac")]
        public async Task<IActionResult> Edit(int id, [Bind("Naziv,OpisProizvoda,Cijena,URLSlike")] Proizvod proizvod)
        {
            if (id != proizvod.ProizvodId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proizvod);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProizvodExists(proizvod.ProizvodId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(proizvod);
        }

        // GET: Proizvod/Delete/5
        [Authorize(Roles = "Prodavac")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvod = await _context.Proizvodi
                .FirstOrDefaultAsync(m => m.ProizvodId == id);
            if (proizvod == null)
            {
                return NotFound();
            }

            return View(proizvod);
        }

        // POST: Proizvod/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Prodavac")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proizvod = await _context.Proizvodi.FindAsync(id);
            _context.Proizvodi.Remove(proizvod);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProizvodExists(int id)
        {
            return _context.Proizvodi.Any(e => e.ProizvodId == id);
        }
    }
}
