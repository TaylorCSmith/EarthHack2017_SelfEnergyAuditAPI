using EnergyAudit.Api.Model;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyAudit.Api.Data
{
    public class DataClient
    {
        private readonly IDocumentClient _client;
        private const string _database = "EnergyAudit";

        public DataClient()
        {
            var endpoint = new Uri("https://localhost:8081");
            var key = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
            _client = new DocumentClient(endpoint, key);
        }

        public IEnumerable<Appliance> Test()
        {
            var query = UriFactory.CreateDocumentCollectionUri(_database, "Appliances");
            var request = _client.CreateDocumentQuery<Appliance>(query);
            var appliances = request.ToList();
            return appliances;
        }

        //public IEnumerable<Model.User> Insert()
        //{
        //    var query = UriFactory.CreateDocumentCollectionUri(_database, "Users");
        //    var request = _client.UpsertDocumentAsync(query, );
        //    request.Wait();
        //    var response = request.Result;

        //    // DONE: create model for user
        //    // insert method takes in a user and passes that to UpsertDocumentAsync request
        //}

        public async void CreateCollection<T>()
        {
            var collectionName = typeof(T).Name;
            var databaseUri = UriFactory.CreateDatabaseUri(_database);

            var collection = new DocumentCollection { Id = collectionName };
            var response = await _client.CreateDocumentCollectionAsync(databaseUri, collection);
        }
    }
}
