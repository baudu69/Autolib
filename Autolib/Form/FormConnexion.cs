using System.ComponentModel.DataAnnotations;

namespace Autolib.Form
{
    public class FormConnexion
    {
        [Required, MaxLength(80)] 
        public string idClient { get; set; } 
        
        public string mdpClient { get; set; }
    }
}