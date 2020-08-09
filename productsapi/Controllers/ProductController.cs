using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using productsapi.Models;
using productsapi.Repositories;

namespace productsapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        ProductRepo demo = new ProductRepo();

        [Route("")]
        [HttpGet]
        public IActionResult get()
        {

            IEnumerable<Product> products = demo.getAll();

            return Ok(products);
        }
        [Route("")]
        [HttpPost]
        public IActionResult add (Product product)
        {
            List<Product> list = ProductRepo.products as List<Product>;
            //product.id = demo.id() + 1;
            list.Add(product);
            return Ok();
        }

    }
}
