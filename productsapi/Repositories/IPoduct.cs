using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    interface IProduct
    {
        IEnumerable<Product> getAll();
        Product getOneById();
        int addProduct(Product product);
        bool editProduct(int id);
        bool deleteProduct(int id);
        Category getProductCategory(int id);


        //Product getProductImages();
    }
}
