using organisationsapi.Context;
using organisationsapi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.Repositories
{
    public class OrganisationRepo : IOrganisation
    {
        OrganisationContext _context;

        public OrganisationRepo(OrganisationContext context)
        {
            _context = context;
        }

        public Organisation GetOneById(Guid id)
        {
            return _context.Organisation.FirstOrDefault(x => x.Id == id&&x.Status);
        }

        public IEnumerable<Organisation> GetAll()
        {
            return _context.Organisation.Where(x=>x.Status).ToList();
        }

        public void Add(Organisation entity)
        {
            _context.Add(entity);
        }

        public void Edit(Guid id, Organisation entity)
        {
            entity.Id = id;
            _context.Update(entity);
        }

        public void Delete(Guid id)
        {
            Organisation organisation = _context.Organisation.FirstOrDefault(x => x.Id == id);

            if (organisation != null)
            {
                organisation.Status = false;
                _context.Update(organisation);
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
