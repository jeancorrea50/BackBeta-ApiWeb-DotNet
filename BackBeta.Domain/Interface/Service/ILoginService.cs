using BackBeta.Domain.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Interface.Service
{
    public interface ILoginService
    {
        Task<object> ObterLogin(LoginDto user);
    }
}
