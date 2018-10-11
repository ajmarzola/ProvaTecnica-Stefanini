using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProvaTecnica.Entity
{
    public class Customer
    {
        [Key, Required(ErrorMessage = "Necessário Informar o Código"), ForeignKey("Customer")]
        public int Id { get; set; }

        [MaxLength(15), Required(ErrorMessage = "Necessário Informar o Primeiro Nome")]
        public string FirstName { get; set; }

        [MaxLength(15)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Necessário Informar a Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        [RegularExpression(@"b[A-Z0-9._%-]+@[A-Z0-9.-]+.[A-Z]{2,4}b", ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        public bool IsActive { get; set; }

        public static IList<Customer> Convert(string pContent)
        {
            var ret = new List<Customer>();
            var lines = pContent.Split(';').ToList<string>();

            foreach (var line in lines)
            {
                var register = line.Split(',');
                var customer = new Customer();
                customer.Id = int.Parse(register[0]);
                customer.FirstName = register[1];
                customer.LastName = register[2];
                customer.BirthDate = DateTime.Parse(register[3]);
                customer.IsActive = bool.Parse(register[4]);
                ret.Add(customer);
            }

            return ret;
        }
    }
}