using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using LambdaSample.Core.Models;
using LambdaSample.Core.Models.Requests;
using LambdaSample.Core.Settings;
using Microsoft.Extensions.Options;
using System.Net;
using System.Text.Json;

namespace LambdaSample.Core.Services
{
    public class DynamoService : IDynamoService
    {
        private readonly IAmazonDynamoDB _dynamoDB;
        private readonly IOptions<DatabaseSettings> _databaseSettings;

        public DynamoService(IAmazonDynamoDB dynamoDB, IOptions<DatabaseSettings> databaseSettings)
        {
            _dynamoDB = dynamoDB;
            _databaseSettings = databaseSettings;
        }

        public async Task<bool> CreateAsync(ParentRequest parent)
        {
            var customerAsJson = JsonSerializer.Serialize(parent);
            var itemAsDocument = Document.FromJson(customerAsJson);
            var itemAsAttributes = itemAsDocument.ToAttributeMap();

            var createItemRequest = new PutItemRequest
            {
                TableName = _databaseSettings.Value.TableName,
                Item = itemAsAttributes
            };

            var response = await _dynamoDB.PutItemAsync(createItemRequest);
            return response.HttpStatusCode == HttpStatusCode.OK;
        }

        public async Task<Parent?> GetAsync(int id)
        {
            var request = new GetItemRequest
            {
                TableName = _databaseSettings.Value.TableName,
                Key = new Dictionary<string, AttributeValue>
                {
                    { "Id", new AttributeValue { S = id.ToString() } }
                }
            };

            var response = await _dynamoDB.GetItemAsync(request);
            if (response.Item.Count == 0)
            {
                return null;
            }

            var itemAsDocument = Document.FromAttributeMap(response.Item);
            return JsonSerializer.Deserialize<Parent>(itemAsDocument.ToJson());
        }
    }
}
