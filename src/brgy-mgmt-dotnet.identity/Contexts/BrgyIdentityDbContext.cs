using brgy_mgmt_dotnet.domain.Models;
using brgy_mgmt_dotnet.identity.Configurations;
using brgy_mgmt_dotnet.identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.identity.Contexts
{
    public class BrgyIdentityDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, IdentityUserLogin<Guid>, AppRoleClaim, IdentityUserToken<Guid>>
    {
        public BrgyIdentityDbContext(DbContextOptions<BrgyIdentityDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new AppUserConfig().Configure(modelBuilder.Entity<AppUser>());
            new AppRoleConfig().Configure(modelBuilder.Entity<AppRole>());
            //modelBuilder.ApplyConfiguration(new AppUserRoleConfig());
            new AppUserRoleConfig().Configure(modelBuilder.Entity<AppUserRole>());
            new AppUserClaimConfig().Configure(modelBuilder.Entity<AppUserClaim>());
            new AppRoleClaimConfig().Configure(modelBuilder.Entity<AppRoleClaim>());
        }
    }
}
