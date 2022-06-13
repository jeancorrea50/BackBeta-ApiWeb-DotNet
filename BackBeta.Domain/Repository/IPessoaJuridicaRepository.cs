using BackBeta.Domain.Entities;
using BackBeta.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Repository
{
    public interface IPessoaJuridicaRepository : IRepository<PessoaJuridicaEntity>
    {
        IEnumerable<PessoaJuridicaEntity> pessoaJuridicas { get; }
        PessoaJuridicaEntity ObterPorId(int id);
        void Delete(int id);
        void Update(PessoaJuridicaEntity pessoaJuridica);
        public void Salvar(PessoaJuridicaEntity pessoaJuridica);
        public PessoaJuridicaEntity Detalhes(PessoaJuridicaEntity pessoaJuridica);
        public void Save();
    }
}
