using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }

        public string Nome { get; set; }

    }
}
