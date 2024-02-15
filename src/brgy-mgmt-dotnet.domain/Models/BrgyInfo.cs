using brgy_mgmt_dotnet.domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.domain.Models
{
    public class BrgyInfo : BaseModel
    {
        public string Name { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string District { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
    }
}
