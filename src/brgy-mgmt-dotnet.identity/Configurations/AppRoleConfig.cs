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
                 },
                 new AppRole
                 {
                     Id = new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556"),
                     Name = "Main_Official",
                     NormalizedName = "MAIN_OFFICIAL",
                     Description = "Main_Official"
                 },
                 new AppRole
                 {
                     Id = new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"),
                     Name = "SK_Official",
                     NormalizedName = "SK_OFFICIAL",
                     Description = "SK_Official"
                 }
            );
        }
    }
}
