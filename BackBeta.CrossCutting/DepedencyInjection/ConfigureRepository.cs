using BackBeta.Domain.Interface.Repository;
using BackBeta.Infrastructure.CrossCutting.IoC.Context;
using BackBeta.Infrastructure.CrossCutting.IoC.Repositories;
using BackBeta.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace BackBeta.Infrastructure.CrossCutting.IoC.DepedencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDepedenciesRepository(IServiceCollection serviceCollection)
        
        {
            serviceCollection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IProdutoRepository, ProdutoRepository>();
            serviceCollection.AddScoped<ILoginRepository, LoginRepository>();
            serviceCollection.AddScoped<IUserRepository, UserRepository>();


            serviceCollection.AddDbContext<MyDbContext>(
                options => options.UseSqlServer("Password = 123456; Persist Security Info = True; User ID = jeancorrea; Initial Catalog = BaseApi; Data Source = JEANCORREA\\SQLEXPRESS"));

        }

    }
}
