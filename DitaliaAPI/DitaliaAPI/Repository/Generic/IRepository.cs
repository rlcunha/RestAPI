using System.Collections.Generic;
using DitaliaAPI.Model.Base;

namespace DitaliaAPI.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T FindById(int id);
        List<T> FindAll();
        T Create(T item);
        T Update(T item);
       void Delete(long id);

    }
}
