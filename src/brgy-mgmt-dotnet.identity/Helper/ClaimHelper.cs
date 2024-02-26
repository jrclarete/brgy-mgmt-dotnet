using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.identity.Helper
{
    internal static class ClaimHelper
    {
        public static string SerializePermissions(params int[] permissions)
        {
            return permissions.Serialize();
        }

        public static List<string> DeserializePermissions(this Claim claim)
        {
            return claim.Value.Deserialize<List<string>>();
        }
    }
}
