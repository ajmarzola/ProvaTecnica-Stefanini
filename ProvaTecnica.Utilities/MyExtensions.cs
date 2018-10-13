using ProvaTecnica.Entity;
using System;

namespace ProvaTecnica.Utilities
{
    public static class MyExtensions
    {
        public static Customer ToCustomer(this String str)
        {
            var customer = new Customer();
            var fields = str.Split(',');
            customer.Id = int.Parse(fields[0]);
            customer.FirstName = fields[1];
            customer.LastName = fields[2];
            customer.BirthDate = DateTime.Parse(fields[3]);
            customer.Email = fields[4];
            customer.IsActive = bool.Parse(fields[5]);
            return customer;
        }

        public static Product ToProduct(this String str)
        {
            var customer = new Product();
            var fields = str.Split(',');
            customer.Id = int.Parse(fields[0]);
            customer.FirstName = fields[1];
            customer.LastName = fields[2];
            customer.BirthDate = DateTime.Parse(fields[3]);
            customer.Email = fields[4];
            customer.IsActive = bool.Parse(fields[5]);
            return customer;
        }
    }
}
