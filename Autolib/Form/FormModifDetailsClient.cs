using System.ComponentModel.DataAnnotations;

namespace Autolib.Form
{
    public class FormModifDetailsClient
    {
        [Required, MaxLength(80)] 
        public string nomClient { get; set; } 
        [Required, MaxLength(80)] 
        public string prenomClient { get; set; } 
        [MaxLength(80)] 
        public string naissanceClient { get; set; } 
        
        public string mdpClient { get; set; }
        
        public string validMdpClient { get; set; }
    }
}