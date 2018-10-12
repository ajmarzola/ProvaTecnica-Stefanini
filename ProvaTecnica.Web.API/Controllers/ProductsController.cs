using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProvaTecnica.Entity;
using ProvaTecnica.Business;

namespace ProvaTecnica.Web.API.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public IQueryable<Product> GetProducts()
        {
            using (ProductsBLL bll = new ProductsBLL())
            {
                return bll.GetProducts();
            }
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> GetProduct(int id)
        {
            Product product;

            using (ProductsBLL bll = new ProductsBLL())
            {
                product = await bll.GetProduct(id);
            }

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProduct(int id, Product Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Product.Id)
            {
                return BadRequest();
            }

            using (ProductsBLL bll = new ProductsBLL())
            {
                int ret = await bll.PutProduct(id, Product);

                if (ret == 0)
                    return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> PostProduct(Product Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (ProductsBLL bll = new ProductsBLL())
            {
                await bll.PostProduct(Product);
            }

            return CreatedAtRoute("DefaultApi", new { id = Product.Id }, Product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> DeleteProduct(int id)
        {
            using (ProductsBLL bll = new ProductsBLL())
            {
                if (bll.ProductExists(id))
                    await bll.DeleteProduct(id);
                else
                    return NotFound();
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            using (ProductsBLL bll = new ProductsBLL())
            {
                return bll.ProductExists(id);
            }
        }
    }
}