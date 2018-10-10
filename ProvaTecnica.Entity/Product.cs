using System.ComponentModel.DataAnnotations;

namespace ProvaTecnica.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(15), MinLength(5)]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}