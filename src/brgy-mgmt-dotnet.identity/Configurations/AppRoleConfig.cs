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
    public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(100);

            var hasher = new PasswordHasher<AppUser>();
            builder.HasData(
                 new AppRole
                 {
                     Id = new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47"),
                     Name = "Administrator",
                     NormalizedName = "ADMINISTRATOR",
                     Description = "Administrator"
                 }
            );
        }
    }
}
