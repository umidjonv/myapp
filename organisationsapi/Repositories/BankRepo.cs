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
            Bank bank = _context.Bank.FirstOrDefault(x => x.Id == id);
            if (bank != null)
            {
                bank.Status = false;
                _context.Update(bank);
            }
        }

        public void Edit(int id, Bank entity)
        {
            entity.Id = id;
            
            _context.Update(entity);
        }

        public IEnumerable<Bank> GetAll()
        {
            return _context.Bank.Where(x=>x.Status).ToList();
        }

        public Bank GetOneById(int id)
        {
            return _context.Bank.FirstOrDefault(x => x.Id == id&&x.Status);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
