using BackBeta.Domain.Entities;
using BackBeta.Domain.Interface.Repository;
using BackBeta.Infrastructure.CrossCutting.IoC.Context;
using BackBeta.Infrastructure.CrossCutting.IoC.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BackBeta.Persistence.Repository
{
    public class LoginRepository : BaseRepository<UserEntity>, ILoginRepository
    {
        private DbSet<UserEntity> _dataset;
        public LoginRepository(MyDbContext context) : base(context)
        {
            _dataset = context.Set<UserEntity>();
        }
        public async Task<UserEntity> ObterLogin(string email)
        {
            // FirstOrDefaultAsync retorna o primeiro registro que encontrar
            return await _dataset.FirstOrDefaultAsync(x => x.Email.Equals(email));
        }

    }
}
