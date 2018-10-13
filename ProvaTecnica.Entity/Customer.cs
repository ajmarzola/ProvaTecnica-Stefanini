using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace ProvaTecnica.Entity
{
    public class Customer
    {
        [Key, Required(ErrorMessage = "Necessário Informar o Código")]
        public int Id { get; set; }

        [MaxLength(15), Required(ErrorMessage = "Necessário Informar o Primeiro Nome")]
        public string FirstName { get; set; }

        [MaxLength(15)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Necessário Informar a Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }

        [RegularExpression(@"b[A-Z0-9._%-]+@[A-Z0-9.-]+.[A-Z]{2,4}b", ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Product> Products { get; set; }

        public static Customer Convert(string pContent)
        {
            var register = pContent.Split(',');
            var customer = new Customer();
            customer.Id = int.Parse(register[0]);
            customer.FirstName = register[1];
            customer.LastName = register[2];
            customer.BirthDate = DateTime.ParseExact(register[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            customer.Gender = register[4];
            customer.Email = register[5];
            customer.IsActive = bool.Parse(register[6]);
            return customer;
        }
    }
}