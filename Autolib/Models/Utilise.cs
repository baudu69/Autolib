using System;

namespace Autolib.Models
{
    public class Utilise
    {
        private AutolibContext unContext;

        public int Vehicule { get; set; }

        public int Client { get; set; }

        public DateTime date { get; set; }
        
        public int borne_depart { get; set; }
        
        public int borne_arrive { get; set; }
        
        public Vehicule leVehicule { get; set; }
        
        public Client leClient { get; set; }
        
        public Borne laBorneDepart { get; set; }
        
        public Borne laBorneArrive { get; set; }
    }
}