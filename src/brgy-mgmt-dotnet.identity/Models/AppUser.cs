using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.identity.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public int? ExternalUserId { get; set; }
        public string CustomUsername { get; set; } = null!;

        public ICollection<AppUserRole>? AppUserRoles { get; set; }
    }
}
