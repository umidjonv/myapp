using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        DemoClass demo = new DemoClass();

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            
            IEnumerable<Product> products = demo.GetProducts();

            return Ok(products);
        }

        [Route("")]
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            List<Product> list = DemoClass.products as List<Product>;

            
            product.id = demo.NewID()+1;
            list.Add(product);

            return Ok(product.id.ToString());

            



            
        }

    }
}


