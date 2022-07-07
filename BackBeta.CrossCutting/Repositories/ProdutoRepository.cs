using BackBeta.Domain.Entities;
using BackBeta.Domain.Interface.Repository;
using BackBeta.Infrastructure.CrossCutting.IoC.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Infrastructure.CrossCutting.IoC.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyDbContext _context;
        private DbSet<ProdutoEntity> _dataset;

        public ProdutoRepository(MyDbContext context)
        {
            _context = context;
            _dataset = _context.Set<ProdutoEntity>();

        }
        public IEnumerable<ProdutoEntity> ObterTodos()
        {
            return _dataset.Include(p => p.Categoria)
                           .Include(x => x.Fornecedor)
                           .ThenInclude(f => f.FornecedorContato)
                           .ToList();
        }
    }
}
