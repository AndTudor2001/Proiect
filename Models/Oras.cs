namespace Proiect.Models
{
    public class Oras
    {
        public int Id { get; set; }
        public string? Nume { get; set; }
        public int? TaraID { get; set; }
        public Tara? Tara { get; set; }
        public string? Descriere { get; set; }
        public ICollection<Prezentare>? Prezentari { get; set; }
        public ICollection<Hotel>? Hoteluri { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Rezervare>? Rezervari { get; set; }

    }
}
