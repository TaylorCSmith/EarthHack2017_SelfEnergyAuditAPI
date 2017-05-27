using EnergyAudit.Api.Data;
using EnergyAudit.Api.Model;
using System;
using System.Linq;

namespace EnergyAudit.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new DataClient();

            var appliances = client.Query<Appliance>();
            var previous = appliances.First();

            var user = new User
            {
                Name = "Taylor Smith",
                PreviousAppliance = previous,
            };

            var task = client.Insert(user);
            task.Wait();

            Console.ReadLine();
        }
    }
}