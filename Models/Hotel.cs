using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string? Nume { get; set; }
        public int? OrasID { get; set; }
        public Oras Oras { get; set; }
        public int? TaraID { get; set; }
        public Tara Tara { get; set; }

        public string? TipCamera { get; set; }
       
        public int NrPers { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
  [Range(0.01, 1500, ErrorMessage ="Pretul nu poate fi mai mare de 1500 eur!")]

        public decimal? PretCamera { get; set; }
        [Range(1, 5, ErrorMessage ="Ratingul maxim posibil este 5!")]
        public int? Rating { get; set; }

        public ICollection<Prezentare>? Prezentari { get; set; }
        public ICollection<Rezervare>? Rezervari { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<PrezHotel> PrezHoteluri { get; set; }
    }
}
