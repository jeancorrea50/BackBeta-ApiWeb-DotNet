using BackBeta.AppService.Service;
using BackBeta.AppService.Interface;
using Microsoft.Extensions.DependencyInjection;
using BackBeta.Domain.Interface.Service;
using BackBeta.Domain.Services;
using BackBeta.Domain.Service;

namespace BackBeta.Infrastructure.CrossCutting.IoC.DepedencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependeciesService (IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProdutoService, ProdutoService>();
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();

        }
    }
}
