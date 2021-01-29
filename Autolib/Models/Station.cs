using System;

namespace Autolib.Models
{
    public class Station
    {
        private AutolibContext context;
        
        public int idStation { get; set; }
        
        public Decimal Latitude { get; set; }
        
        public Decimal Longitude { get; set; }
        
        public string adresse { get; set; }
        
        public int numero { get; set; }
        
        public string ville { get; set; }

        public int code_postal { get; set; }
        
        public int nbVoituresLibres { get; set; }
        
        public int nbPlaces { get; set; }
    }
}