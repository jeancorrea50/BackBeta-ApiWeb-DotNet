using BackBeta.Domain.Interface.Services.PessoaJuridica;
using BackBeta.Domain.Interface.Services.User;
using BackBeta.Domain.Interfaces.Services.User;
using BackBeta.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.CrossCutting.DepedencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependeciesService (IServiceCollection serviceCollection)
        {
                     // cada operação que tiver enjeção de dependencia ele vai ter um using e cada vez que foi ele vai ultilizar 1 vezes
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<IPessoaJuridicaService, PessoaJuridicaService>();


        }
    }
}
