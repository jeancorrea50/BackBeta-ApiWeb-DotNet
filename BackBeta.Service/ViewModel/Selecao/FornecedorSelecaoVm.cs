using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.AppService.ViewModel.Selecao
{
    public class FornecedorSelecaoVm
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public ICollection<FornecedorContatoSelecaoVm> FornecedorContato { get; set; }

    }
}
