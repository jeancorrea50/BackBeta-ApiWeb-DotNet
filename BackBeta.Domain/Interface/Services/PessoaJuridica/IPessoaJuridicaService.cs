using BackBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Interface.Services.PessoaJuridica
{
    public interface IPessoaJuridicaService
    {
        Task<PessoaJuridicaEntity> ObterPorId(int id);
        Task<IEnumerable<PessoaJuridicaEntity>> ObterTodos();
        Task<PessoaJuridicaEntity> Criar(PessoaJuridicaEntity pessoa);
        Task<PessoaJuridicaEntity> Alterar(PessoaJuridicaEntity pessoa);
        Task<bool> Excluir(int id);
    }
}
