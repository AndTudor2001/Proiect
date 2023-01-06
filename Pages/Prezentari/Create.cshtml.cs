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

    public class CreateModel : PrezHotelPageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public CreateModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["oras"] = new SelectList(_context.Set<Oras>(), "Id", "Nume");
            ViewData["tara"] = new SelectList(_context.Set<Tara>(), "ID", "Nume");
            ViewData["OrasD"] = new SelectList(_context.Set<Oras>(), "Id", "Descriere");
  
            var prezentare = new Prezentare();
            prezentare.PrezHoteluri = new List<PrezHotel>();
            PopulateCatAsignate(_context, prezentare);
            return Page();
        }

        [BindProperty]
        public Prezentare Prezentare { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(string[] selectedCategories)
        {
            var newPrez = new Prezentare();
            if (selectedCategories != null)
            {
                newPrez.PrezHoteluri = new List<PrezHotel>();
                foreach (var cat in selectedCategories)
                {
                    var catToAdd = new PrezHotel
                    {
                        HotelID = int.Parse(cat)
                    };
                    newPrez.PrezHoteluri.Add(catToAdd);
                }
            }
            if (await TryUpdateModelAsync<Prezentare>(newPrez, "Prezentare",

                i => i.TaraID, i => i.OrasID

                ))
            {
                PopulateCatAsignate(_context, newPrez);
                return Page();
            }
            _context.Prezentare.Add(newPrez);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }

}

