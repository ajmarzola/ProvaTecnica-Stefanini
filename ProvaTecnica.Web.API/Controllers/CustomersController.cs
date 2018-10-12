using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProvaTecnica.Business;
using ProvaTecnica.Entity;

namespace ProvaTecnica.Web.API.Controllers
{
    public class CustomersController : ApiController
    {
        // GET: api/Customers
        public IQueryable<Customer> GetCustomers()
        {
            using (CustomersBLL bll = new CustomersBLL())
            {
                return bll.GetCustomers();
            }
        }

        // GET: api/Customers/5
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> GetCustomer(int id)
        {
            Customer customer;

            using (CustomersBLL bll = new CustomersBLL())
            {
                customer = await bll.GetCustomer(id);
            }

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Customers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer.Id)
            {
                return BadRequest();
            }

            using (CustomersBLL bll = new CustomersBLL())
            {
                int ret = await bll.PutCustomer(id, customer);

                if (ret == 0)
                    return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Customers
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> PostCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (CustomersBLL bll = new CustomersBLL())
            {
                await bll.PostCustomer(customer);
            }

            return CreatedAtRoute("DefaultApi", new { id = customer.Id }, customer);
        }

        // DELETE: api/Customers/5
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> DeleteCustomer(int id)
        {
            using (CustomersBLL bll = new CustomersBLL())
            {
                if (bll.CustomerExists(id))
                    await bll.DeleteCustomer(id);
                else
                    return NotFound();
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private bool CustomerExists(int id)
        {
            using (CustomersBLL bll = new CustomersBLL())
            {
                return bll.CustomerExists(id);
            }
        }
    }
}