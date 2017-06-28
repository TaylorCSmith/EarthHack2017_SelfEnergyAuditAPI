using Newtonsoft.Json;
using System;

namespace EnergyAudit.Api.Model
{
    public class Appliance
    {
        [JsonProperty("id")]
        public Guid? Id { get; set; }
        public string Brand { get; set; }
        public string ApplianceName { get; set; }
        public bool EnergyStar { get; set; }
        public bool CCE { get; set; }
        public string Amperage { get; set; }
    }
}
