namespace Proiect.Models
{
    public class Rezervare
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Hotel { get; set; }
        public string Locatie { get; set; }
        public string TipCamera { get; set; }
        public int Persoane { get; set; }
        public DateTime DataSosire { get; set; }
        public DateTime  DataPlecare { get; set; }
    }
}
