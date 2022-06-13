using BackBeta.CrossCutting.Data.Context;
using BackBeta.CrossCutting.DataRepository;
using BackBeta.Domain.Entities;
using BackBeta.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.CrossCutting.Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;
    public UserImplementation(MyDbContext context) : base(context)
    {
        _dataset = context.Set<UserEntity>();
    }
    public async Task<UserEntity> ObterLogin(string email)
    {
            // FirstOrDefaultAsync retorna o primeiro registro que encontrar
      return await _dataset.FirstOrDefaultAsync(x => x.Email.Equals(email));
    }
        public IList<UserEntity> users => _dataset.ToList<UserEntity>();

    }

}
