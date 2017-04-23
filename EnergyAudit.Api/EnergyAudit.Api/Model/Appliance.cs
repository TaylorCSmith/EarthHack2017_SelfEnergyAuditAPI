using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyAudit.Api.Model
{
    public class Appliance
    {
        public string Brand { get; set; }
        public string ApplianceName { get; set; }
        public bool EnergyStar { get; set; }
        public bool CCE { get; set; }
        public string Amperage { get; set; }
    }
}
