using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Rezervari
{
    [Authorize(Roles = "Admin")]

    public class EditModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public EditModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rezervare Rezervare { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Rezervare == null)
            {
                return NotFound();
            }

            var rezervare =  await _context.Rezervare.FirstOrDefaultAsync(m => m.Id == id);
            if (rezervare == null)
            {
                return NotFound();
            }
            Rezervare = rezervare;

          
            var tott = _context.Hotel
                .Include(b => b.Oras)
                .Include(b => b.Tara)
                .Select(x => new
                {
                    x.Id,
                    tot = x.Nume + " din " + x.Oras.Nume + ", " + x.Tara.Nume
                });

            ViewData["HotelID"] = new SelectList(tott, "Id", "tot");
            ViewData["HotelT"] = new SelectList(_context.Set<Hotel>(), "Id", "TipCamera");
            ViewData["MembruID"] = new SelectList(_context.Set<Membru>(), "Id", "Numetot");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Rezervare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RezervareExists(Rezervare.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RezervareExists(int id)
        {
          return _context.Rezervare.Any(e => e.Id == id);
        }
    }
}
