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
    public class AppUserClaimConfig : IEntityTypeConfiguration<AppUserClaim>
    {
        public void Configure(EntityTypeBuilder<AppUserClaim> builder)
        {
            #region Navigations
            builder.HasOne(x => x.AppUser).WithMany(y => y.AppUserClaims).HasForeignKey(x => x.UserId).IsRequired(true);
            #endregion
        }
    }
}
