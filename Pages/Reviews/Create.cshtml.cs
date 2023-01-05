using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Reviews
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

            var tott = _context.Hotel
                .Include(b => b.Oras)
                .Include(b => b.Tara)
                .Select(x => new
                {
                    x.Id,
                    tot = x.Nume + " din " + x.Oras.Nume + ", " + x.Tara.Nume
                });

            ViewData["HotelID"] = new SelectList(tott, "Id", "tot");
            ViewData["OrasID"] = new SelectList(_context.Set<Oras>(), "Id", "Nume");
            ViewData["TaraID"] = new SelectList(_context.Set<Tara>(), "ID", "Nume");
           
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Review.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
