using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Entities
{
    public class FornecedorContatoEntity
    {
        public int Id { get; set; }
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public FornecedorEntity Fornecedor { get; set; }

    }
}
