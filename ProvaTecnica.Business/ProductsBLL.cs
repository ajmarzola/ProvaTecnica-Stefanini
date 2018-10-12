using System;
using System.Linq;
using System.Threading.Tasks;
using ProvaTecnica.Data;
using ProvaTecnica.Entity;

namespace ProvaTecnica.Business
{
    public class ProductsBLL : IDisposable
    {
        public IQueryable<Product> GetProducts()
        {
            using (ProductsDAL dal = new ProductsDAL())
            {
                return dal.GetProducts();
            }
        }

        public async Task<Product> GetProduct(int id)
        {
            using (ProductsDAL dal = new ProductsDAL())
            {
                return await dal.GetProduct(id);
            }
        }

        public async Task<int> PutProduct(int id, Product product)
        {
            if (!ProductExists(id))
            {
                using (ProductsDAL dal = new ProductsDAL())
                {
                    return await dal.PutProduct(id, product);
                }
            }
            else
            {
                return 0;
            }
        }

        public async Task<int> PostProduct(Product product)
        {
            if (ProductExists(product.Id))
            {
                using (ProductsDAL dal = new ProductsDAL())
                {
                    return await dal.PostProduct(product);
                }
            }
            else
            {
                return 0;
            }
        }

        public async Task<int> DeleteProduct(int id)
        {
            if (ProductExists(id))
            {
                using (ProductsDAL dal = new ProductsDAL())
                {
                    return await dal.DeleteProduct(id);
                }
            }
            else
            {
                return 0;
            }
        }

        public bool ProductExists(int id)
        {
            using (ProductsDAL dal = new ProductsDAL())
            {
                return dal.ProductExists(id);
            }
        }

        public void Dispose()
        {
            //
        }
    }
}