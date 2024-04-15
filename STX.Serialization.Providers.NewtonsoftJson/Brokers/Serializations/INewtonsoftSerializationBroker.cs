// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace STX.Serialization.Providers.NewtonsoftJson.Brokers.Serializations
{
    internal interface INewtonsoftSerializationBroker
    {
        void SerializeAsync<T>(JsonTextWriter jsonWriter, T @object);
    }
}
