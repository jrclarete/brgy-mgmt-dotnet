using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.identity.Models
{
    public class AppUserClaim : IdentityUserClaim<Guid>
    {
        #region Navigations
        public AppUser? AppUser { get; set; }
        #endregion
    }
}
