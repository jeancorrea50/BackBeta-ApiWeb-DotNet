using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackBeta.Domain.Entities;

namespace BackBeta.Domain.Interface.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> Criar(T item);
        Task<T> Alterar(T item);
        Task<bool> Excluir(int id);
        Task<T> ObterPorId(int id);
        Task<IEnumerable<T>> ObterTodos();
    }
}
