using BackBeta.Domain.Entities;
using BackBeta.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> ObterLogin(string email);
        public IList<UserEntity> users { get; }

    }
}
