using System;

namespace Autolib.Models
{
    public class Vehicule
    {
        private AutolibContext context;
        
        public int IdVehicule { get; set; }
        
        public int RFID { get; set; }
        
        public int EtatBatterie { get; set; }
        
        public string Disponibilite { get; set; }
        
        public Decimal Latitude { get; set; }
        
        public Decimal Longitude { get; set; }
        
        public int Type_Vehicule { get; set; }
        
        public Type_Vehicule Type { get; set; }
        
        public Borne laBorne { get; set; }
    }
}