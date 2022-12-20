using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Prezentari
{
    public class CreateModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public CreateModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["OrasID"] = new SelectList(_context.Set<Oras>(), "Id", "Nume");
            ViewData["TaraID"] = new SelectList(_context.Set<Tara>(), "ID", "Nume");
            ViewData["OrasD"] = new SelectList(_context.Set<Oras>(), "Id", "Descriere");
            ViewData["HotelID"] = new SelectList(_context.Set<Hotel>(), "Id", "Nume");
            return Page();
        }

        [BindProperty]
        public Prezentare Prezentare { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Prezentare.Add(Prezentare);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
