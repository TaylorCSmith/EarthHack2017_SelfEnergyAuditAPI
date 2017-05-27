using Newtonsoft.Json;
using System;

namespace EnergyAudit.Api.Model
{
    public class User
    {
        [JsonProperty("id")]
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public Appliance PreviousAppliance { get; set; }
        public Appliance CurrentAppliance { get; set; }
    }
}
