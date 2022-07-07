using BackBeta.AppService.Interface;
using BackBeta.AppService.Service;
using Microsoft.Extensions.DependencyInjection;

namespace BackBeta.Infrastructure.CrossCutting.IoC.DepedencyInjection
{
    public class ConfigureAppService
    {
        public static void ConfigureDepedenciesAppService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProdutoAppService, ProdutoAppService>();
            serviceCollection.AddScoped<IUserAppService, UserAppService>();
            serviceCollection.AddScoped<ILoginAppService, LoginAppService>();

        }
    }
}
