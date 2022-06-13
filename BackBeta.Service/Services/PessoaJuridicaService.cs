using BackBeta.Domain.Entities;
using BackBeta.Domain.Interface.Services.PessoaJuridica;
using BackBeta.Domain.Interfaces;
using BackBeta.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Service.Services
{
    public class PessoaJuridicaService : IPessoaJuridicaService
    {
        private IRepository<PessoaJuridicaEntity> _repository;

        public PessoaJuridicaService(IRepository<PessoaJuridicaEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Excluir(int id)
        {
            return await _repository.ExcluirAsync(id);
        }

        public async Task<PessoaJuridicaEntity> ObterPorId(int id)
        {
            return await _repository.SelecionarAsync(id);
        }

        public async Task<IEnumerable<PessoaJuridicaEntity>> ObterTodos()
        {
            return await _repository.SelecionarAsync();
        }

        public async Task<PessoaJuridicaEntity> Criar(PessoaJuridicaEntity PessoaJuridica)
        {
            return await _repository.InserirAsync(PessoaJuridica);
        }

        public async Task<PessoaJuridicaEntity> Alterar(PessoaJuridicaEntity PessoaJuridica)
        {
            return await _repository.AtualizarAsync(PessoaJuridica);
        }
      
    }
}
