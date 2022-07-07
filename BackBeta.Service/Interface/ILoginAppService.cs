using BackBeta.Domain.Dto.User;
using System.Threading.Tasks;

namespace BackBeta.AppService.Interface
{
    public interface ILoginAppService
    {
        Task<object> ObterLogin(LoginDto user);
    }
}
