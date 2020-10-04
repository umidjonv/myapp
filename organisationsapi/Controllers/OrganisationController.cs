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

            IEnumerable<OrgDTO> readOrg = _mapper.Map<IEnumerable<OrgDTO>>(organisations);

            return Ok(readOrg);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AddNew(OrgDTO organisation)
        {
            if(organisation != null)
            {
                //if (organisation.BankId != 0)
                //    organisation.BankDetails = _bankrepo.GetOneById(organisation.BankId);

                Organisation orgNew = _mapper.Map<Organisation>(organisation);

                _orgrepo.Add(orgNew);

                if (_orgrepo.SaveChanges() > 0)
                    return Ok("Created");
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(string id, OrgDTO orgWrite)
        {
            Guid guid = Guid.Empty;

            if (Guid.TryParse(id, out guid) && orgWrite != null)
            {
                Organisation orgEdit = _mapper.Map<Organisation>(orgWrite);

                _orgrepo.Edit(guid, orgEdit);
                

                if (_orgrepo.SaveChanges() > 0)
                    return Ok("Updated");
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string id)
        {
            Guid guid = Guid.Empty;
            
            if(Guid.TryParse(id, out guid))
            {
                _orgrepo.Delete(guid);

                if (_orgrepo.SaveChanges() > 0)
                    return Ok("Deleted");
            }

            return NotFound();
        }
    }
}
