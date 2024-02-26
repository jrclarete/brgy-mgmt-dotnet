using brgy_mgmt_dotnet.identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.identity.Configurations
{
    public class AppRoleClaimConfig : IEntityTypeConfiguration<AppRoleClaim>
    {
        public void Configure(EntityTypeBuilder<AppRoleClaim> builder)
        {
            #region Navigations
            builder.HasOne(x => x.AppRole).WithMany(y => y.AppRoleClaims).HasForeignKey(x => x.RoleId).IsRequired(true);
            #endregion

            builder.HasData(
                new AppRoleClaim
                {
                    Id = 1,
                    RoleId = new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47"),
                    ClaimType = "HOUSEHOLD",
                    ClaimValue = "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]"
                },
                new AppRoleClaim
                {
                    Id = 2,
                    RoleId = new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556"),
                    ClaimType = "HOUSEHOLD",
                    ClaimValue = "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]"
                },
                new AppRoleClaim
                {
                    Id = 3,
                    RoleId = new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"),
                    ClaimType = "HOUSEHOLD",
                    ClaimValue = "[\"READ\"]"
                },
                new AppRoleClaim
                {
                    Id = 4,
                    RoleId = new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47"),
                    ClaimType = "BRGY_INFO",
                    ClaimValue = "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]"
                }
            );
        }
    }
}
