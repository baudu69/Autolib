namespace Autolib.Models
{
    public class Client
    {
        private AutolibContext context;
        
        public int IdClient { get; set; }
        
        public string Nom { get; set; }
        
        public string Prenom { get; set; }
        
        public string Date_naissance { get; set; }
        
        public string Password { get; set; }
    }
}