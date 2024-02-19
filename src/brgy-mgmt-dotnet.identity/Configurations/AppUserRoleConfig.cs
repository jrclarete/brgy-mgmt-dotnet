using brgy_mgmt_dotnet.identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.identity.Configurations
{
    public class AppUserRoleConfig : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            #region Navigations
            builder.HasOne(x => x.AppUser).WithMany(y => y.AppUserRoles).HasForeignKey(x => x.UserId).IsRequired(true);
            builder.HasOne(x => x.AppRole).WithMany(y => y.AppUserRoles).HasForeignKey(x => x.RoleId).IsRequired(true);
            #endregion

            builder.HasData(
                new AppUserRole
                {
                    RoleId = new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47"),
                    UserId = new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735")
                }
            );
        }
    }
}
