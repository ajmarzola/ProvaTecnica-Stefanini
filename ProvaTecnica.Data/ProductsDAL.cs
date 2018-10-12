using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using ProvaTecnica.Data.Context;
using ProvaTecnica.Entity;

namespace ProvaTecnica.Data
{
    public class ProductsDAL : IDisposable
    {
        private ProvaTecnicaContext db = new ProvaTecnicaContext();

        public IQueryable<Product> GetProducts()
        {
            return db.Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            return await db.Products.FindAsync(id);
        }

        public async Task<int> PutProduct(int id, Product product)
        {
            db.Entry(product).State = EntityState.Modified;

            try
            {
                return await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return 0;
            }
        }

        public async Task<int> PostProduct(Product product)
        {
            db.Products.Add(product);
            return await db.SaveChangesAsync();
        }

        public async Task<int> DeleteProduct(int id)
        {
            Product Product = await db.Products.FindAsync(id);
            db.Products.Remove(Product);
            return await db.SaveChangesAsync();
        }

        public bool ProductExists(int id)
        {
            return db.Products.Count(e => e.Id == id) > 0;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}