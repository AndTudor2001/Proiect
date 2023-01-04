using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect.Data;

namespace Proiect.Models
{
    public class PrezHotelPageModel : PageModel
    {
        public List<CatAsignate>? CatAsignateList;
        public void PopulateCatAsignate(ProiectContext context,
        Prezentare prezentare)
        {
            var allCategories = context.Hotel;
            var hotelCategories = new HashSet<int>(
            prezentare.PrezHoteluri.Select(c => c.PrezID)); //
            CatAsignateList = new List<CatAsignate>();
            foreach (var cat in allCategories)
            {
                CatAsignateList.Add(new CatAsignate
                {
                    CategorieID = cat.Id,
                    Nume = cat.Nume,
                    Checked = hotelCategories.Contains(cat.Id)
                }); ;
            }
        }
        public void UpdateBookCategories(ProiectContext context,
        string[] selectedCategories, Prezentare hotelToUpdate)
        {
            if (selectedCategories == null)
            {
                hotelToUpdate.PrezHoteluri = new List<PrezHotel>();
                return;
            }
            var selectedCategoriesHS = new HashSet<string>(selectedCategories);
            var hotelCategories = new HashSet<int>
            (hotelToUpdate.PrezHoteluri.Select(c => c.Hotel.Id));
            foreach (var cat in context.Hotel)
            {
                if (selectedCategoriesHS.Contains(cat.Id.ToString()))
                {
                    if (!hotelCategories.Contains(cat.Id))
                    {
                        hotelToUpdate.PrezHoteluri.Add(
                        new PrezHotel
                        {
                            PrezID = hotelToUpdate.Id,
                            HotelID = cat.Id
                        });
                    }
                }
                else
                {
                    if (hotelCategories.Contains(cat.Id))
                    {
                        PrezHotel courseToRemove
                        = hotelToUpdate
                        .PrezHoteluri
                        .SingleOrDefault(i => i.HotelID == cat.Id);
                        context.Remove(courseToRemove);
                    }
                }
            }
        }


    }
}
