using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    interface Iproduct
    {
        List<Product> getAll();
        Product gaetOneById();
        Guid addNew(Product product);
    }
}
