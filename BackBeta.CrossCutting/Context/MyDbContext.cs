using Microsoft.EntityFrameworkCore;
using BackBeta.Infrastructure.CrossCutting.Mapping;
using BackBeta.Domain.Entities;

namespace BackBeta.Infrastructure.CrossCutting.IoC.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<UserEntity> User { get; set; }
        public DbSet<ProdutoEntity> Produto { get; set; }
        public DbSet<CategoriaEntity> Categoria { get; set; }
        public DbSet<FornecedorEntity> Fornecedor { get; set; }
        public DbSet<FornecedorContatoEntity> FornecedorContato { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating ( ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity> (new UserMap().Configure);
            modelBuilder.Entity<ProdutoEntity>(new ProdutoMap().Configure);
            modelBuilder.Entity<CategoriaEntity>(new CategoriaMap().Configure);
            modelBuilder.Entity<FornecedorEntity>(new FornecedorMap().Configure);
            modelBuilder.Entity<FornecedorContatoEntity>(new FornecedorContatoMap().Configure);
        }
    }
}
