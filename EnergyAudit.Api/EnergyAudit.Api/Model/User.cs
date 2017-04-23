using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyAudit.Api.Model
{
    public class User
    {
        public string Name { get; set; }
        public string PreviousAppliance { get; set; }
        public string CurrentAppliance { get; set; }
    }
}
