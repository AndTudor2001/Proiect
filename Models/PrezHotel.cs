namespace Proiect.Models
{
    public class PrezHotel
    {
        public int ID { get; set; }
        public int PrezID { get; set; }
        public Prezentare? Prezentare { get; set; }
        public int HotelID { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
