using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackBeta.Domain.Entities;

namespace BackBeta.Domain.Interfaces
{
    public interface IRepository<T> where T : Base
    {
        Task<T> InserirAsync(T item);
        Task<T> AtualizarAsync(T item);
        Task<bool> ExcluirAsync(int id);
        Task<T> SelecionarAsync(int id);
        Task<IEnumerable<T>> SelecionarAsync();
        Task<bool> ExisteAsync(int id);
    }
}
