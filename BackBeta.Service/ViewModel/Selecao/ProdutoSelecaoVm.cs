using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.AppService.ViewModel.Selecao
{
    public class ProdutoSelecaoVm
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public string Cor { get; set; }
        public CategoriaSelecaoVm Categoria { get; set; }
        public FornecedorSelecaoVm Fornecedor { get; set; }

    }
}
