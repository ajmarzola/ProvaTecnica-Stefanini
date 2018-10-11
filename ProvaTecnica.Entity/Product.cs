﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProvaTecnica.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [MaxLength(10)]
        public string Name { get; set; }

        public static IList<Product> Convert(string pContent)
        {
            var ret = new List<Product>();
            var lines = pContent.Split(';').ToList<string>();

            foreach (var line in lines)
            {
                var register = line.Split(',');
                var product = new Product();
                product.Id = int.Parse(register[0]);
                product.CustomerId = int.Parse(register[1]);
                product.Name = register[2];
                ret.Add(product);
            }

            return ret;
        }
    }
}