using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        private DateTime? _CreateAt;

        public DateTime? CreateAt
        {
            get { return _CreateAt; }
            set { _CreateAt = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime? UpdateAt{ get; set; }

    }
}
