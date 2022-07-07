using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Entities
{
    public class ProdutoEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Cor { get; set; }
        public decimal Valor { get; set; }
        public int FornecedorId { get; set; }
        public int CategoriaId { get; set; }

        public CategoriaEntity Categoria { get; set; }
        public FornecedorEntity Fornecedor { get; set; }

    }
}
