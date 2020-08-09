using System;
using System.Collections.Generic;
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
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _repo;
        private readonly IMapper _mapper;

        public CategoryController(ICategory repo , IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
       
        [HttpGet]
        public IActionResult get()
        {

            IEnumerable<Category> categories = _repo.getAll();

            IEnumerable<CategoryReadDTO> readCat = _mapper.Map<IEnumerable<CategoryReadDTO>>(categories);

            return Ok(readCat);
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult addNew(CategoryWriteDTO category)
        {
           if( category != null)
            {

                if (category.parentId != null)
                    category.parent = _repo.getOneById(category.parentId);

                Category cat = _mapper.Map<Category>(category);
                _repo.add(cat);
                _repo.saveChanges();
                return CreatedAtRoute("{id}", cat.id);

            }
           else { return BadRequest(); }
        }
    }
}
