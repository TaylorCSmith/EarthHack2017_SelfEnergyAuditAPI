using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EnergyAudit.Api.Data;
using EnergyAudit.Api.Model;
using EnergyAudit.Data;

namespace EnergyAudit.Api.Controllers
{
    [Route("api/energyaudit")]
    public class EnergyAuditController : Controller
    {
        private IDataClient _client;

        public EnergyAuditController(IDataClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        [HttpGet]
        [Route("user")]
        public IActionResult GetUser()
        {
            var user = _client.Query<User>().FirstOrDefault();
            return Ok(user);
        }

        // http post request
        // move current appliance to previous appliance
        // send current appliance
        // store inside of current appliance...

    }
}
