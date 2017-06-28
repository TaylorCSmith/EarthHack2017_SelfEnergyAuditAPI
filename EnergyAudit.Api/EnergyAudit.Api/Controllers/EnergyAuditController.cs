using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
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
    }
}
