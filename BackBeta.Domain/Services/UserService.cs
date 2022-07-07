using AutoMapper;
using BackBeta.Domain.Dto.User;
using BackBeta.Domain.Entities;
using BackBeta.Domain.Interface;
using BackBeta.Domain.Interface.Repository;
using BackBeta.Domain.Interface.Service;
using BackBeta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BackBeta.Domain.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Excluir(int id)
        {
            return await _repository.Excluir(id);
        }

        public async Task<UserEntity> ObterPorId(int id)
        {
            var entity = await _repository.ObterPorId(id);

            return entity;
        }
        public async Task<IEnumerable<UserEntity>> ObterTodos()
        {
            var listaUser = await _repository.ObterTodos();

            return listaUser;
        }

        public async Task<UserEntity> Criar(UserEntity user)
        {
            var result = await _repository.Criar(user);

            return result;
        }

        public async Task<UserEntity> Alterar(UserEntity user)
        {
            var result = await _repository.Alterar(user);

            return result;
        }
    }
}
