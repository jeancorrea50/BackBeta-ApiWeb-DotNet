using BackBeta.CrossCutting.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.CrossCutting.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Password = 123456; Persist Security Info = True; User ID=jeancorrea; Initial Catalog = BaseApi; Data Source = JEANCORREA\\SQLEXPRESS";
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new MyDbContext(optionsBuilder.Options);
        }
    }


}
