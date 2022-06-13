using BackBeta.CrossCutting.Data.Context;
using BackBeta.CrossCutting.DataRepository;
using BackBeta.Domain.Entities;
using BackBeta.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.CrossCutting.Data.Implementations
{
    public class PessoaJuridicaImplementation : BaseRepository<PessoaJuridicaEntity>, IPessoaJuridicaRepository
    {
        private DbSet<PessoaJuridicaEntity> _dataset;
        public PessoaJuridicaImplementation(MyDbContext context) : base(context)
    {
        _dataset = context.Set<PessoaJuridicaEntity>();
    }
        public IEnumerable<PessoaJuridicaEntity> pessoaJuridicas => _dataset.ToList<PessoaJuridicaEntity>();
        public PessoaJuridicaEntity ObterPorId(int id)
        {
            return _dataset.Where(
                x => x.Id == id).FirstOrDefault();
        }
        public void Delete(int id)
        {

            PessoaJuridicaEntity pessoaJuridica = _dataset.Find(id);
            _dataset.Remove(pessoaJuridica);
            Save();
        }
        public void Update(PessoaJuridicaEntity pessoaJuridica)
        {
            _dataset.Update(pessoaJuridica).State = EntityState.Modified;
            Save();
        }
        public void Salvar(PessoaJuridicaEntity pessoaJuridica)
        {

            _dataset.Add(pessoaJuridica);
            Save();
        }
        public PessoaJuridicaEntity Detalhes(PessoaJuridicaEntity pessoaJuridica)
        {
            return _dataset.FirstOrDefault(x => x.Cnpj != null && x.Cnpj == pessoaJuridica.Cnpj);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }

}
