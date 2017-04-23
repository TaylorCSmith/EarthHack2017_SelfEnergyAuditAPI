using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EnergyAudit.Api.Controllers
{
    [Route("api/energyaudit")]
    public class EnergyAuditController : Controller
    {
        // GET api/values
        [HttpGet]
        [Route("test")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
