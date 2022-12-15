namespace Proiect.Models
{
    public class Tara
    {
        public int ID { get; set; }
        public string? Nume { get; set; }
        public string? Continent { get; set; }
        public ICollection<Prezentare>?  Prezentari { get; set; }
        public ICollection<Oras>? Orase { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Hotel> ? Hoteluri { get; set; }
        public ICollection<Rezervare>? Rezervari { get; set; }


    }
}
