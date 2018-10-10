using System.ComponentModel.DataAnnotations;

namespace ProvaTecnica.Entity
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15), MinLength(5)]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"b[A-Z0-9._%-]+@[A-Z0-9.-]+.[A-Z]{2,4}b", ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
    }
}
