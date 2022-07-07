using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackBeta.Domain.Dto.User;
using BackBeta.Domain.Entities;

namespace BackBeta.AppService.Interface
{
    public interface IUserAppService
    {
        Task<UsuarioDto> ObterPorId(int id);
        Task<IEnumerable<UsuarioDto>> ObterTodos();
        Task<CriarUsuarioResultadoDto> Criar(CriarUsuarioDto user);
        Task<AtualizarUsuarioResultadoDto> Alterar(AtualizarUsuarioDto user);
        Task<bool> Excluir(int id);
    }
}
