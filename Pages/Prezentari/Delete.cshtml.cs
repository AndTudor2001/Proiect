using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Prezentari
{
    [Authorize(Roles = "Admin")]

    public class DeleteModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DeleteModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Prezentare Prezentare { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Prezentare == null)
            {
                return NotFound();
            }

            var prezentare = await _context.Prezentare
                   .Include(i => i.Hotel)
                .Include(i => i.Oras)
                .Include(i => i.Tara)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (prezentare == null)
            {
                return NotFound();
            }
            else 
            {
                Prezentare = prezentare;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Prezentare == null)
            {
                return NotFound();
            }
            var prezentare = await _context.Prezentare.FindAsync(id);

            if (prezentare != null)
            {
                Prezentare = prezentare;
                _context.Prezentare.Remove(Prezentare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
