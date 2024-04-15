// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace STX.Serialization.Providers.NewtonsoftJson.Brokers.Serializations
{
    internal class NewtonsoftSerializationBroker : INewtonsoftSerializationBroker
    {
        private readonly JsonSerializerSettings jsonSerializerSettings;

        public NewtonsoftSerializationBroker(JsonSerializerSettings jsonSerializerSettings) =>
            this.jsonSerializerSettings = jsonSerializerSettings;

        public async ValueTask SerializeAsync<T>(
            Stream utf8JsonStream,
            T @object,
            CancellationToken cancellationToken = default)
        {
            await Task.Run(() =>
            {
                using (var writer = new StreamWriter(utf8JsonStream))
                using (var jsonWriter = new JsonTextWriter(writer))
                {
                    var serializer = JsonSerializer.Create(jsonSerializerSettings);
                    serializer.Serialize(writer, @object);
                }
            }, cancellationToken);
        }
    }
}
