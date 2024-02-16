using brgy_mgmt_dotnet.domain.Models;
using brgy_mgmt_dotnet.infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.infrastructure.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Resident> Residents { get; set; }
        public DbSet<BrgyInfo> BrgyInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ResidentConfig().Configure(modelBuilder.Entity<Resident>());
            new BrgyInfoConfig().Configure(modelBuilder.Entity<BrgyInfo>());
        }
    }
}
