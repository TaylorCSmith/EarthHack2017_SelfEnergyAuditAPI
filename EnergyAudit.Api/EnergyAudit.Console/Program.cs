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

            var appliance1 = new Appliance
            {
                ApplianceName = "IcyHot Boosted Monkey", 
                Brand = "Bronze V",
                CCE = true,
                Amperage = "2343243243",
                EnergyStar = false
            };

            var appliance2 = new Appliance
            {
                ApplianceName = "Carried to Bronze V",
                Brand = "Zoo",
                CCE = false,
                Amperage = "2343",
                EnergyStar = false
            };

            var task = client.Insert(appliance1);
            var task2 = client.Insert(appliance2);
            task.Wait();
            task2.Wait();
            var documentId = task.Result;

            var document = client.Query<Appliance>().Where(d => d.Id == documentId).FirstOrDefault();

            Console.WriteLine(document.Amperage);
            Console.ReadLine();
        }
    }
}