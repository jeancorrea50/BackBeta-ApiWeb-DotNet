using AutoMapper;
using BackBeta.AppService.Interface;
using BackBeta.Domain.Dto.User;
using BackBeta.Domain.Entities;
using BackBeta.Domain.Interface.Service;
using BackBeta.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BackBeta.AppService.Service
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserAppService(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<bool> Excluir(int id)
        {
            return await _userService.Excluir(id);
        }

        public async Task<UsuarioDto> ObterPorId(int id)
        {
            var entity = await _userService.ObterPorId(id);

            return _mapper.Map<UsuarioDto>(entity);
        }
        public async Task<IEnumerable<UsuarioDto>> ObterTodos()
        {
            var listEntity = await _userService.ObterTodos();
            var dto = _mapper.Map<IEnumerable<UsuarioDto>>(listEntity);

            return dto;
        }

        public async Task<CriarUsuarioResultadoDto> Criar(CriarUsuarioDto user)
        {
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model);

            var result = await _userService.Criar(entity);
            return _mapper.Map<CriarUsuarioResultadoDto>(result);
        }

        public async Task<AtualizarUsuarioResultadoDto> Alterar(AtualizarUsuarioDto user)
        {
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model);

            var result = await _userService.Alterar(entity);
            return _mapper.Map<AtualizarUsuarioResultadoDto>(result);
        }
    }
}
