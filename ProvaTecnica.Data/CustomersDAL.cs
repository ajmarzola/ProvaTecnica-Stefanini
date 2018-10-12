using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using ProvaTecnica.Data.Context;
using ProvaTecnica.Entity;

namespace ProvaTecnica.Data
{
    public class CustomersDAL : IDisposable
    {
        private ProvaTecnicaContext db = new ProvaTecnicaContext();

        public IQueryable<Customer> GetCustomers()
        {
            return db.Customers;
        }

        public async Task<Customer> GetCustomer(int id)
        {
            return await db.Customers.FindAsync(id);
        }

        public async Task<int> PutCustomer(int id, Customer customer)
        {
            db.Entry(customer).State = EntityState.Modified;

            try
            {
                return await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return 0;
            }
        }

        public async Task<int> PostCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            return await db.SaveChangesAsync();
        }

        public async Task<int> DeleteCustomer(int id)
        {
            Customer customer = await db.Customers.FindAsync(id);
            db.Customers.Remove(customer);
            return await db.SaveChangesAsync();
        }

        public bool CustomerExists(int id)
        {
            return db.Customers.Count(e => e.Id == id) > 0;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}