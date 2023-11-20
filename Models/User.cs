using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Models
{
    public class User
    {
        [Required] // Verificar que se importo using Ssytem.ComponentModel.DataAnnotations

        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

    }
}