// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System.IO;
using Newtonsoft.Json;

namespace STX.Serialization.Providers.NewtonsoftJson.Brokers.Serializations
{
    internal class NewtonsoftSerializationBroker : INewtonsoftSerializationBroker
    {
        private readonly JsonSerializer jsonSerializer;

        public NewtonsoftSerializationBroker(JsonSerializerSettings jsonSerializerSettings) =>
            jsonSerializer = JsonSerializer.Create(jsonSerializerSettings);

        public void SerializeAsync<T>(StreamWriter writer, T @object) =>
            jsonSerializer.Serialize(writer, @object);
    }
}
