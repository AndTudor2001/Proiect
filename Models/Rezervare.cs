using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Rezervare
    {
        public int Id { get; set; }
        public int? MembruID { get; set; }
        public Membru? Membru { get; set; }
        public int? HotelID { get; set; }
        public Hotel? Hotel { get; set; }
        public int? OrasID { get; set; }
        public Oras? Oras { get; set; }
        public int? TaraID { get; set; }
        public Tara? Tara { get; set; }
        [Range(1, 10, ErrorMessage = "Numarul maxim de persoane permise pentru o rezervare este 10")]
        public int? Persoane { get; set; }
       
        public DateTime? DataSosire { get; set; }


        public DateTime?  DataPlecare { get; set; }

    }
}
