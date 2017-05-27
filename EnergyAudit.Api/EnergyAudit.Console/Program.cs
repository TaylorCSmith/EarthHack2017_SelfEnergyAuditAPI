using EnergyAudit.Api.Data;
using EnergyAudit.Api.Model;

namespace EnergyAudit.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new DataClient();

            var databaseTask = client.CreateDatabase();
            databaseTask.Wait();

            var task = client.CreateCollection<Appliance>();
            task.Wait(); //can't await within Main method of console app, so we create a task, then wait for that task to complete.
        }
    }
}