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
            return _context.Organisation.FirstOrDefault(x => x.id == id);
        }

        public IEnumerable<Organisation> GetAll()
        {
            return _context.Organisation.ToList();
        }

        public void Add(Organisation entity)
        {
            _context.Add(entity);
        }

        public void Edit(Organisation entity)
        {
            _context.Update(entity);
        }

        public void Delete(Guid id)
        {
            _context.Organisation.FirstOrDefault(x => x.id == id).status = false;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
