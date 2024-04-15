// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace STX.Serialization.Providers.NewtonsoftJson.Brokers.Serializations
{
    internal class NewtonsoftSerializationBroker : INewtonsoftSerializationBroker
    {
        private readonly JsonSerializer jsonSerializer;

        public NewtonsoftSerializationBroker(JsonSerializerSettings jsonSerializerSettings) =>
            jsonSerializer = JsonSerializer.Create(jsonSerializerSettings);

        public void SerializeAsync<T>(JsonTextWriter jsonWriter, T @object) =>
            jsonSerializer.Serialize(jsonWriter, @object);
    }
}
