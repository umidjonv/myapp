using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productsapi.DTO;
using productsapi.Models;
using productsapi.Repositories;

namespace productsapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _prorepo;

        private readonly ICategory _catrepo;

        private readonly IMapper _mapper;

        private readonly CategoryReadDTO catRead;

        public ProductController(IProduct prorepo , ICategory catrepo , IMapper mapper)
        {
            _prorepo = prorepo;
            _catrepo = catrepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult get()
        {
            IEnumerable<Product> products = _prorepo.GetAll();
            IEnumerable<ProductReadDTO> readProduct = _mapper.Map<IEnumerable<ProductReadDTO>>(products);

            return Ok(readProduct);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult add (ProductWriteDTO product)
        {

            if(product != null)
            {
                if (product.categoryId != catRead.id)
                    product.category = _catrepo.GetOneById(product.categoryId);

                    Product prodNew = _mapper.Map<Product>(product);

                    _prorepo.Add(prodNew);

                    if (_prorepo.SaveChanges() > 0)
                        return Ok("created");
            }

            return BadRequest(); 
        }


        [HttpPut]
        [Route("{id}")]
        public IActionResult edit(ProductWriteDTO product)
        {
            if(product != null)
            {
                if (product.categoryId != null)
                    product.category = _catrepo.GetOneById(product.categoryId);
  
                Product prodEdit = _mapper.Map<Product>(product);

                    _prorepo.Edit(prodEdit);
                    _prorepo.SaveChanges();

                    if (_prorepo.SaveChanges() > 0)
                        return Ok("updated");
                
            }

            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult delete(Guid id)
        {
            if(id != null)
            {
                _prorepo.Delete(id);

                if (_prorepo.SaveChanges() > 0)
                    return Ok("deleted");
            }

            return NotFound();
        }
    }
}
