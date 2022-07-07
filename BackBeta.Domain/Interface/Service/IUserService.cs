using BackBeta.Domain.Dto.User;
using BackBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Interface.Service
{
    public interface IUserService
    {
        Task<bool> Excluir(int id);
        Task<UserEntity> ObterPorId(int id);
        Task<IEnumerable<UserEntity>> ObterTodos();
        Task<UserEntity> Criar(UserEntity user);
        Task<UserEntity> Alterar(UserEntity user);



    }
}
