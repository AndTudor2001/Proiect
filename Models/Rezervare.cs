namespace Proiect.Models
{
    public class Rezervare
    {
        public int Id { get; set; }
        public string? Nume { get; set; }
        public string? Prenume { get; set; }
        public int? HotelID { get; set; }
        public Hotel? Hotel { get; set; }
        public int? OrasID { get; set; }
        public Oras? Oras { get; set; }
        public int? TaraID { get; set; }
        public Tara? Tara { get; set; }
        public int? Persoane { get; set; }
        public DateTime? DataSosire { get; set; }
        public DateTime?  DataPlecare { get; set; }

    }
}
