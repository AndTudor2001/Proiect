using Proiect.Migrations;

namespace Proiect.Models
{
    public class PrezentareData
    {
        public IEnumerable<Prezentare> Prezentari { get; set; }
        public IEnumerable<Hotel> Hoteluri { get; set; }
        public IEnumerable<PrezHotel> PrezHoteluri { get; set; }
    }
}
