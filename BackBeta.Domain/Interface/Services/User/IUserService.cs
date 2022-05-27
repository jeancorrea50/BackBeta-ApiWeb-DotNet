using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackBeta.Domain.Entities;

namespace BackBeta.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserEntity> Get(int id);
        Task<IEnumerable<UserEntity>> GetAll();
        Task<UserEntity> Post(UserEntity user);
        Task<UserEntity> Put(UserEntity user);
        Task<bool> Delete(int id);
    }
}
