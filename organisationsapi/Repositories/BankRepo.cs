using organisationsapi.Context;
using organisationsapi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.Repositories
{
    public class BankRepo : IBank
    {
        OrganisationContext _context;

        public BankRepo(OrganisationContext context)
        {
            _context = context;
        }

        public void Add(Bank entity)
        {
            _context.Bank.Add(entity);
        }

        public void Delete(int id)
        {
            _context.Bank.FirstOrDefault(x => x.id == id).status = false;
        }

        public void Edit(Bank entity)
        {
            _context.Update(entity);
        }

        public IEnumerable<Bank> GetAll()
        {
            return _context.Bank.ToList();
        }

        public Bank GetOneById(int id)
        {
            return _context.Bank.FirstOrDefault(x => x.id == id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
