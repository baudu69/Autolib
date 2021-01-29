namespace Autolib.Models
{
    public class Type_Vehicule
    {
        private AutolibContext context;
        
        public int IdType { get; set; }
        
        public string Categorie { get; set; }
        
        public string Type_vehicule { get; set; }
    }
}