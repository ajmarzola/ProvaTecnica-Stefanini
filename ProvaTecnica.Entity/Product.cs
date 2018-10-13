using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProvaTecnica.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        public string Name { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public static Product Convert(string pContent)
        {
            var register = pContent.Split(',');
            var product = new Product();
            product.Id = int.Parse(register[0]);
            product.Customer.Id = int.Parse(register[1]);
            product.Name = register[2];
            return product;
        }
    }
}