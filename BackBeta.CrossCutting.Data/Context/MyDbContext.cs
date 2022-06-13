
using BackBeta.Domain.Entities;
using BackBeta.CrossCutting.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackBeta.Infrastructure.CrossCutting.Mapping;

namespace BackBeta.CrossCutting.Data.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PessoaJuridicaEntity> PessoaJuridicas { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating ( ModelBuilder modelBuilder)
        {
            base.OnModelCreating (modelBuilder);

            modelBuilder.Entity<UserEntity> (new UserMap().Configure);
        }

    }
}
