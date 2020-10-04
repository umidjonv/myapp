using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using organisationsapi.DTO;
using organisationsapi.Entites;
using organisationsapi.Repositories;

namespace organisationsapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBank _bank;

        private readonly IMapper _mapper;

        public BankController(IBank bank, IMapper mapper)
        {
            _bank = bank;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBank()
        {
            IEnumerable<Bank> bank = _bank.GetAll();

            IEnumerable<BankDTO> bankRead = _mapper.Map<IEnumerable<BankDTO>>(bank);

            return Ok(bankRead);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AddNew(BankDTO bankWrite)
        {
            if (bankWrite != null)
            {

                Bank bank = _mapper.Map<Bank>(bankWrite);
                _bank.Add(bank);

                if (_bank.SaveChanges() > 0)
                    return Ok("created");

            }
            return BadRequest();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetOneById(int id)
        {
            Bank bankDet = _bank.GetOneById(id);

            if (bankDet != null)
            {
                BankDTO bankRead = _mapper.Map<BankDTO>(bankDet);
                return Ok(bankRead);
            }

            return NotFound();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(int id, BankDTO writeDTO)
        {
            if(writeDTO != null && id>0)
            {
                Bank bank = _mapper.Map<Bank>(writeDTO);
                _bank.Edit(id,bank);

                if (_bank.SaveChanges() > 0)
                    return Ok("updated");
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if(id > 0)
            {
                _bank.Delete(id);

                if (_bank.SaveChanges() > 0)
                    return Ok("Deleted");
            }
            return NotFound();
        }
    }
}
