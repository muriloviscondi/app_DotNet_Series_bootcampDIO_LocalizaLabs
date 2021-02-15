using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();

        T IdResponse(int id);

        void Create(T entity);

        void Delete(int id);

        void Alter(int id, T entity);

        int nextId();
    }
}