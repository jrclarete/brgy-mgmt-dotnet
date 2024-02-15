using brgy_mgmt_dotnet.domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
namespace brgy_mgmt_dotnet.infrastructure.ModelConfigs
{
    public class ResidentConfig : IEntityTypeConfiguration<Resident>
    {
        public void Configure(EntityTypeBuilder<Resident> builder)
        {
            builder.ToTable("Residents");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.MiddleName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Suffix).HasMaxLength(10);
            builder.Property(x => x.BirthDate).HasColumnType("date").IsRequired();
            builder.Property(x => x.Gender).HasColumnType("int").IsRequired();
            builder.Property(x => x.Nationality).HasMaxLength(20);
            builder.Property(x => x.Street).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Barangay).HasMaxLength(100).IsRequired();
            builder.Property(x => x.District).HasMaxLength(100).IsRequired();
            builder.Property(x => x.City).HasMaxLength(100).IsRequired();
            builder.Property(x => x.State).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ZipCode).HasMaxLength(50).IsRequired();

            builder.Property(x => x.CreatedBy).HasMaxLength(450);
            builder.Property(x => x.DateCreated).HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.UpdatedBy).HasMaxLength(450);
            builder.Property(x => x.DateUpdated).HasColumnType("datetime2");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
