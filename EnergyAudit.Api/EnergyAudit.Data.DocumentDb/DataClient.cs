using EnergyAudit.Data;
using EnergyAudit.Data.DocumentDb.Extensions;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyAudit.Api.Data
{
    public class DataClient : IDataClient
    {
        private readonly IDocumentClient _client;
        private const string _database = "EnergyAudit";

        public DataClient(IDocumentClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public IEnumerable<T> Query<T>()
        {
            var collection = typeof(T).GetCollectionId();

            var query = UriFactory.CreateDocumentCollectionUri(_database, collection);
            var request = _client.CreateDocumentQuery<T>(query);
            var appliances = request.ToList();
            return appliances;
        }

        public async Task<Guid> Insert<T>(T document)
        {
            var collection = typeof(T).GetCollectionId();

            var collectionUri = UriFactory.CreateDocumentCollectionUri(_database, collection);
            var response = await _client.UpsertDocumentAsync(collectionUri, document);
            var documentId = response.Resource.Id;

            return new Guid(documentId);
        }

        public async Task CreateDatabase(string name = _database)
        {
            var database = new Database { Id = name };
            var response = await _client.CreateDatabaseAsync(database);
        }

        public async Task CreateCollection<T>()
        {
            var collectionName = typeof(T).GetCollectionId();
            var databaseUri = UriFactory.CreateDatabaseUri(_database);

            var collection = new DocumentCollection { Id = collectionName };
            var response = await _client.CreateDocumentCollectionAsync(databaseUri, collection);
        }
    }
}
