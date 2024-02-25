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
                },
                new AppUserRole
                {
                    RoleId = new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556"),
                    UserId = new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19")
                },
                new AppUserRole
                {
                    RoleId = new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"),
                    UserId = new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a")
                }
            );
        }
    }
}
