using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActuArte.Models
{
    public class Authentication
    {

        [Required]
        public string? nombreUsuario { get; set; }

        [Required]
        public string? passwordUsuario { get; set; }
        
    }
}
