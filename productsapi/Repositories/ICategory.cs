using System;
using System.Collections.Generic;
using productsapi.Models;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public interface ICategory : IDefaultRepo<Category>
    {
        //IEnumerable<Category> getAll();

        //Category getOneById(int id);

        //void add(Category category);

        //void edit(Category category);

        //void delete(int id);

        Category getParent(Guid id);

        IEnumerable<Category> getChilds(Guid id);

        IEnumerable<Product> getProducts(Guid id);

        //void SaveChanges();

    }
}
