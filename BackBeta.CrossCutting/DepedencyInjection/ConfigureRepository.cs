using BackBeta.CrossCutting.Data.Context;
using BackBeta.CrossCutting.DataRepository;
using BackBeta.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.CrossCutting.DepedencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDepedenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddDbContext<MyDbContext>(
                options => options.UseSqlServer("Password = 123456; Persist Security Info = True; User ID = jeancorrea; Initial Catalog = BaseApi; Data Source = JEANCORREA\\SQLEXPRESS"));

        }

    }
}
