using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Prezentari
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DetailsModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

      public Prezentare Prezentare { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Prezentare == null)
            {
                return NotFound();
            }

            var prezentare = await _context.Prezentare.FirstOrDefaultAsync(m => m.Id == id);
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
    }
}
