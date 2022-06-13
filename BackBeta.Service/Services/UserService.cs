using AutoMapper;
using BackBeta.Domain.Dto.User;
using BackBeta.Domain.Entities;
using BackBeta.Domain.Interfaces;
using BackBeta.Domain.Interfaces.Services.User;
using BackBeta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BackBeta.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;
        private readonly IMapper _mapper;

        public UserService (IRepository<UserEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Excluir(int id)
        {
            return await _repository.ExcluirAsync(id);
        }

        public async Task<UsuarioDto> ObterPorId(int id)
        {
            var entity = await _repository.SelecionarAsync(id);

            return _mapper.Map<UsuarioDto>(entity);
        }
        public async Task<IEnumerable<UsuarioDto>> ObterTodos()
        {
            var listEntity = await _repository.SelecionarAsync();
            var  dto = _mapper.Map<IEnumerable<UsuarioDto>>(listEntity);

            return dto;
        }

        public async Task<CriarUsuarioResultadoDto> Criar(CriarUsuarioDto user)
        {
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model);

            var result = await _repository.InserirAsync(entity);
            return _mapper.Map<CriarUsuarioResultadoDto>(result);
        }

        public async Task<AtualizarUsuarioResultadoDto> Alterar(AtualizarUsuarioDto user)
        {
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model);

            var result = await _repository.AtualizarAsync(entity);
            return _mapper.Map<AtualizarUsuarioResultadoDto>(result);
        }
    }
}
