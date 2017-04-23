using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EnergyAudit.Api.Data;
using EnergyAudit.Api.Model;

namespace EnergyAudit.Api.Controllers
{
    [Route("api/energyaudit")]
    public class EnergyAuditController : Controller
    {
        // GET api/values
        [HttpGet]
        [Route("test")]
        public IEnumerable<Appliance> Get()
        {
            var client = new DataClient();
            var appliances = client.Test();
            return appliances;
        }
    }
}
