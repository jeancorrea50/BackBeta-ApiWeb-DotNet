using BackBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Interface.Repository
{
    public interface ILoginRepository
    {
        Task<UserEntity> ObterLogin(string email);
    }
}
