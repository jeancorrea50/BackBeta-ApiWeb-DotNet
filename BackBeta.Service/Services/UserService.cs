using BackBeta.Domain.Entities;
using BackBeta.Domain.Interfaces;
using BackBeta.Domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BackBeta.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;

        public UserService (IRepository<UserEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

          public async Task<UserEntity> Post(UserEntity user)
        {
            return await _repository.InsertAsync(user);
        }

        public async Task<UserEntity> Put(UserEntity user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}