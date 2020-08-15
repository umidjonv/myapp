using Microsoft.EntityFrameworkCore.Internal;
using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public class ProductRepo : IProduct
    {

        //public static IEnumerable<Product> products;

        //public ProductRepo()
        //{
        //    products = new List<Product>();
        //}


        ProductContext _context;

        public ProductRepo(ProductContext context)
        {
            _context = context;
        }

        public Product GetOneById(Guid id)
        {
            return _context.Product.FirstOrDefault(x => x.id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Product.ToList();
        }

        public void Add(Product entity)
        {
            _context.Product.Add(entity);
        }

        public void Edit(Product entity)
        {
            _context.Update(entity);
        }

        public void Delete(Guid id)
        {
            _context.Product.FirstOrDefault(x => x.id == id).status = false;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        //public Category getProductCategory(Guid id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
