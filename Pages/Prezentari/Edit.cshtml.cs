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

namespace Proiect.Pages.Prezentari
{
    [Authorize(Roles = "Admin")]

    public class EditModel : PrezHotelPageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public EditModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Prezentare Prezentare { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Prezentare == null)
            {
                return NotFound();
            }

            var prezentare =  await _context.Prezentare
                .Include(b => b.PrezHoteluri).ThenInclude(b => b.Hotel)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prezentare == null)
            {
                return NotFound();
            }

            Prezentare = prezentare;
            PopulateCatAsignate(_context, Prezentare);

            ViewData["OrasID"] = new SelectList(_context.Set<Oras>(), "Id", "Nume");
            ViewData["TaraID"] = new SelectList(_context.Set<Tara>(), "ID", "Nume");
            ViewData["OrasD"] = new SelectList(_context.Set<Oras>(), "Id", "Descriere");
          
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id, string[] catSelectate)
        {
            {
                if (id == null)
                {
                    return NotFound();
                }

                var hotelToUpdate = await _context.Prezentare
                   .Include(i => i.Tara)
                   .Include(i=>i.Oras)
                   .Include(i=>i.Hotel)
                .Include(i => i.PrezHoteluri)
                .ThenInclude(i => i.Hotel)
                .FirstOrDefaultAsync(s => s.Id == id);
                if (hotelToUpdate == null)
                {
                    return NotFound();
                }

                if (await TryUpdateModelAsync<Prezentare>(
                hotelToUpdate,
                "Prezentare",
                i => i.TaraID, i => i.OrasID
               
                ))
                {
                    UpdateBookCategories(_context, catSelectate, hotelToUpdate);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Index");
                }
                UpdateBookCategories(_context, catSelectate, hotelToUpdate);
                PopulateCatAsignate(_context, hotelToUpdate);
                return Page();
            }
        }

    }

}
