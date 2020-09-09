using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using organisationsapi.DTO;
using Microsoft.AspNetCore.Mvc;
using organisationsapi.Entites;
using organisationsapi.Repositories;
using System.Data;

namespace organisationsapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationController : ControllerBase
    {
        private readonly IOrganisation _orgrepo;

        private readonly IBank _bankrepo;

        private readonly IMapper _mapper;

        
        
    
        public OrganisationController(IOrganisation orgrepo , IMapper mapper, IBank bankrepo)
        {
            _bankrepo = bankrepo;
            _orgrepo = orgrepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Organisation> organisations = _orgrepo.GetAll();

            IEnumerable<OrgReadDTO> readOrg = _mapper.Map<IEnumerable<OrgReadDTO>>(organisations);

            return Ok(readOrg);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AddNew(OrgWriteDTO organisation)
        {
            if(organisation != null)
            {
                if (organisation.bankId != 0)
                    organisation.bankDetails = _bankrepo.GetOneById(organisation.bankId);

                Organisation orgNew = _mapper.Map<Organisation>(organisation);

                _orgrepo.Add(orgNew);

                if (_orgrepo.SaveChanges() > 0)
                    return Ok("Created");
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(OrgWriteDTO orgWrite)
        {
            if(orgWrite != null)
            {
                if (orgWrite.bankId != 0)
                    orgWrite.bankDetails = _bankrepo.GetOneById(orgWrite.bankId);

                Organisation orgEdit = _mapper.Map<Organisation>(orgWrite);

                _orgrepo.Edit(orgEdit);
                _orgrepo.SaveChanges();

                if (_orgrepo.SaveChanges() > 0)
                    return Ok("Updated");
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(Guid id)
        {
            if(id != null)
            {
                _orgrepo.Delete(id);

                if (_orgrepo.SaveChanges() > 0)
                    return Ok("Deleted");
            }

            return NotFound();
        }
    }
}
