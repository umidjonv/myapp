using organisationsapi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.Repositories
{
    public interface IOrganisation
    {
        IEnumerable<Organisation> GetAll();

        Organisation GetOneById(Guid id);

        void Add(Organisation entity);

        void Edit(Organisation entity);

        void Delete(Guid id);

        int SaveChanges();
    }
}
