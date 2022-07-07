using BackBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Interface.Service
{
    public interface IProdutoService
    {
        IEnumerable<ProdutoEntity> ObterTodos();
    }
}
