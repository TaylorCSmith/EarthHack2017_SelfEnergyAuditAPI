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
        // include calculations for difference in amperage
        // return value of difference
        //[HttpGet]
        //[Route("test")]
        //public IEnumerable<Appliance> Get()
        //{
        //    var client = new DataClient();
        //    var appliances = client.Test();
        //    return appliances;
        //}

        // http post request
        // move current appliance to previous appliance
        // send current appliance
        // store inside of current appliance...

    }
}
