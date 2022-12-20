using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string? Nume { get; set; }
        public int? OrasID { get; set; }
        public Oras? Oras{ get; set; }
        public int? TaraID { get; set; }
        public Tara? Tara { get; set; }

        public string? TipCamera { get; set; }
        public int NrPers { get; set;}
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? PretCamera { get; set; }
        
        public int? Rating { get; set; }

        public ICollection<Prezentare>? Prezentari { get; set; }
        public ICollection<Rezervare>? Rezervari { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
