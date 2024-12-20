using System.ComponentModel.DataAnnotations;

namespace Campuslands.Entities.Request
{
    public class ClienteRequest
    {
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
