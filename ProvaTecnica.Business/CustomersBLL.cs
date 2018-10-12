using System;
using System.Linq;
using System.Threading.Tasks;
using ProvaTecnica.Entity;
using ProvaTecnica.Data;

namespace ProvaTecnica.Business
{
    public class CustomersBLL : IDisposable
    {
        public IQueryable<Customer> GetCustomers()
        {
            using (CustomersDAL dal = new CustomersDAL())
            {
                return dal.GetCustomers();
            }
        }

        public async Task<Customer> GetCustomer(int id)
        {
            using (CustomersDAL dal = new CustomersDAL())
            {
                return await dal.GetCustomer(id);
            }
        }

        public async Task<int> PutCustomer(int id, Customer customer)
        {
            if (!CustomerExists(id))
            {
                using (CustomersDAL dal = new CustomersDAL())
                {
                    return await dal.PutCustomer(id, customer);
                }
            }
            else
            {
                return 0;
            }
        }

        public async Task<int> PostCustomer(Customer customer)
        {
            if (CustomerExists(customer.Id))
            {
                using (CustomersDAL dal = new CustomersDAL())
                {
                    return await dal.PostCustomer(customer);
                }
            }
            else
            {
                return 0;
            }
        }

        public async Task<int> DeleteCustomer(int id)
        {
            if (CustomerExists(id))
            {
                using (CustomersDAL dal = new CustomersDAL())
                {
                    return await dal.DeleteCustomer(id);
                }
            }
            else
            {
                return 0;
            }
        }

        public bool CustomerExists(int id)
        {
            using (CustomersDAL dal = new CustomersDAL())
            {
                return dal.CustomerExists(id);
            }
        }

        public void Dispose()
        {
            //
        }
    }
}