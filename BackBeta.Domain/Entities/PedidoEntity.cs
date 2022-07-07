using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Entities
{
    public class PedidoEntity : BaseEntity
    {
        public virtual List<PedidoDetalheEntity> PedidoDetalhe { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Endereco1 { get; set; }

        public string Endereco2 { get; set; }

        public string Cep { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public decimal PedidoTotal { get; set; }

        public int TotalItensPedido { get; set; }

        public DateTime PedidoEnviado { get; set; }

        public DateTime? PedidoEntregueEm { get; set; }
    }
}
