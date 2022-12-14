namespace Proiect.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Locatie { get; set; }

        public int NrPers { get; set; }
        public int PretCamera { get; set; }
        public int Rating { get; set; }
    }
}
