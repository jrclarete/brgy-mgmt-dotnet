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
    public class AppUserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47"),
                    UserId = new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735")
                }
            );
        }
    }
}
