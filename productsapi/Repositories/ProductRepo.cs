using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public class ProductRepo : IProduct
    {

        public static IEnumerable<Product> products;

        public ProductRepo()
        {
            products = new List<Product>();
        }

        public IEnumerable<Product> getAll()
        {
            return products;
        }

        public Product getOneById()
        {
            throw new NotImplementedException();
        }

        public int addProduct(Product product)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IProduct.getAll()
        {
            throw new NotImplementedException();
        }

        public bool deleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public bool editProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Category getProductCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
