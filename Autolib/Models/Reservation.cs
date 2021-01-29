using System;

namespace Autolib.Models
{
    public class Reservation
    {
        private AutolibContext context;

        public int Vehicule { get; set; }
        
        public int Client { get; set; }
        
        public string Date_reservation { get; set; }
        
        public string Date_echeance { get; set; }
        
        public Vehicule leVehicule { get; set; }
        
        public Client leClient { get; set; }
    }
}