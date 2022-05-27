using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackBeta.Domain.Entities;

namespace BackBeta.Domain.Interfaces
{
    public interface IRepository<T> where T : Base
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(int id);
        Task<T> SelectAsync(int id);
        Task<IEnumerable<T>> SelectAsync();
        Task<bool> ExistAsync(int id);
    }
}
