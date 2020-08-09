using Microsoft.EntityFrameworkCore.ChangeTracking;
//using productsapi.Data;
using productsapi.Entities;
using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public class CategoryRepo : ICategory
    {
        ProductContext _context;

        public CategoryRepo(ProductContext context)
        {
            _context = context;

        }


        public void add(Category category)
        {
            _context.Category.Add(category);
        }


        public void delete(int id)
        {
            _context.Category.FirstOrDefault<Category>(x => x.id == id).status = false;


        }

        public void edit(Category category)
        {
            _context.Category.Update(category);
        }

        public IEnumerable<Category> getAll()
        {
            return _context.Category.ToList();
        }

        public IEnumerable<Category> getChilds(int id)
        {
            return _context.Category.Where(x => x.id == id).ToList();
        }

        public Category getOneById(int id)
        {
            return _context.Category.FirstOrDefault(x => x.id == id);
        }

        public Category getParent(int id)
        {
            return _context.Category.FirstOrDefault(x => x.id == id);
        }

        public IEnumerable<Product> getProducts(int id)
        {
            throw new NotImplementedException();
        }

        public void saveChanges()
        {
            _context.SaveChanges();
        }
    }
}
