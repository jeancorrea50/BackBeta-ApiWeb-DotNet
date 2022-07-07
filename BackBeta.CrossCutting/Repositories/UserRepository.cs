using BackBeta.Domain.Entities;
using BackBeta.Domain.Interface.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackBeta.Infrastructure.CrossCutting.IoC.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IBaseRepository<UserEntity> _repository;

        public UserRepository(IBaseRepository<UserEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Excluir(int id)
        {
            return await _repository.Excluir(id);
        }

        public async Task<UserEntity> ObterPorId(int id)
        {
            return await _repository.ObterPorId(id);

        }
        public async Task<IEnumerable<UserEntity>> ObterTodos()
        {
            return await _repository.ObterTodos();
        }

        public async Task<UserEntity> Criar(UserEntity user)
        {
            return await _repository.Criar(user);
        }

        public async Task<UserEntity> Alterar(UserEntity user)
        {
            return await _repository.Alterar(user);
        }
    }
}
