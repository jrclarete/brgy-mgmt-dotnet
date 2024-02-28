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
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.ExternalUserId).HasColumnType("int");
            builder.Property(x => x.CustomUsername).HasMaxLength(20).IsRequired();


            var hasher = new PasswordHasher<AppUser>();
            builder.HasData(
                 new AppUser
                 {
                     Id = new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     UserName = "admin@localhost.com",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true,
                     CustomUsername = "admin",
                 },
                 new AppUser
                 {
                     Id = new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                     Email = "garyn.green@localhost.com",
                     NormalizedEmail = "GARYN.GREEN@LOCALHOST.COM",
                     UserName = "garyn.green@localhost.com",
                     NormalizedUserName = "GARYN.GREEN@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true,
                     CustomUsername = "ggn",
                     ExternalUserId = 1,
                 },
                 new AppUser
                 {
                     Id = new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                     Email = "jamesina.sanders@localhost.com",
                     NormalizedEmail = "JAMESINA.SANDERS@LOCALHOST.COM",
                     UserName = "jamesina.sanders@localhost.com",
                     NormalizedUserName = "JAMESINA.SANDERS@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true,
                     CustomUsername = "jss",
                     ExternalUserId = 2,
                 }
            );
        }
    }
}
