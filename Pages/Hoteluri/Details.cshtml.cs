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

namespace Proiect.Pages.Hoteluri
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DetailsModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

      public Hotel Hotel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Hotel == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotel.FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }
            else 
            {
                Hotel = hotel;
              
            }
            return Page();
        }
    }
}
