using brgy_mgmt_dotnet.domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
namespace brgy_mgmt_dotnet.infrastructure.Configurations
{
    public class BrgyInfoConfig : IEntityTypeConfiguration<BrgyInfo>
    {
        public void Configure(EntityTypeBuilder<BrgyInfo> builder)
        {
            builder.ToTable("BrgyInfo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Street).HasMaxLength(500).IsRequired();
            builder.Property(x => x.District).HasMaxLength(100).IsRequired();
            builder.Property(x => x.City).HasMaxLength(100).IsRequired();
            builder.Property(x => x.State).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ZipCode).HasMaxLength(50).IsRequired();

            builder.Property(x => x.CreatedBy).HasMaxLength(450);
            builder.Property(x => x.DateCreated).HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.UpdatedBy).HasMaxLength(450);
            builder.Property(x => x.DateUpdated).HasColumnType("datetime2");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.HasData(
                new BrgyInfo
                {
                    Id = 1,
                    Name = "767",
                    Street = "0000001",
                    District = "San Andres Bukid",
                    City = "Manila",
                    State = "Metro Manila",
                    ZipCode = "1017",
                    CreatedBy = "Default",
                    DateCreated = DateTime.Now,
                }
            );
        }
    }
}
