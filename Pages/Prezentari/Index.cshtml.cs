using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Prezentari
{
    public class IndexModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public IndexModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IList<Prezentare> Prezentare { get;set; } = default!;
        public PrezentareData PrezD { get; set; }
        public int PrezID { get; set; }
        public int CategorieID { get; set; }


        public async Task OnGetAsync(int? id, int? categoryID)
        {
            PrezD = new PrezentareData();
           
                PrezD.Prezentari = await _context.Prezentare
                    .Include(b=>b.Tara)
                    .Include(b=>b.Oras)
                    .Include(b=>b.PrezHoteluri)
                    .ThenInclude(b=>b.Hotel)
                    .AsNoTracking()
 .OrderBy(b => b.Hotel.Nume)
 .ToListAsync();
            if (id != null)
            {
               PrezID = id.Value;
                Prezentare prezentare = PrezD.Prezentari
                .Where(i => i.Id == id.Value).Single();
                PrezD.Hoteluri = prezentare.PrezHoteluri.Select(s => s.Hotel);
            }


        }

    }
}
