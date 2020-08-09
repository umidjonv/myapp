using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public interface IDefaultRepo<T>
    {
        IEnumerable<T> getAll();

        T getOneById(int id);

        void add(T entity);

        void edit(T entity);

        void delete(int id);

        void saveChanges();
    }
}
