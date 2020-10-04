using organisationsapi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.Repositories
{
    public interface IBank
    {
        IEnumerable<Bank> GetAll();

        Bank GetOneById(int id);

        void Add(Bank entity);

        void Edit(int id, Bank entity);

        void Delete(int id);

        int SaveChanges();
    }
}
