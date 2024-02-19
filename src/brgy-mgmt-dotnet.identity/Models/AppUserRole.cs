using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.identity.Models
{
    public class AppUserRole : IdentityUserRole<Guid>
    {
        #region Navigations
        public AppUser AppUser { get; set; } = null!;
        public AppRole AppRole { get; set; } = null!;
        #endregion
    }
}
