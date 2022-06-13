using BackBeta.Domain.Dto.User;
using System.Threading.Tasks;

namespace BackBeta.Domain.Interface.Services.User
{
    public interface ILoginService
    {
        Task<object> ObterLogin(LoginDto user);
    }
}
