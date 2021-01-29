namespace Autolib.Models
{
    public class Borne
    {
        private AutolibContext context;

        public int IdBorne { get; set; }
        
        public bool EtatBorne { get; set; }
        
        public int station { get; set; }
        
        public int idVehicule { get; set; }
        
        public Station laStation { get; set; }
        
        public Vehicule leVehicule { get; set; }
    }
}