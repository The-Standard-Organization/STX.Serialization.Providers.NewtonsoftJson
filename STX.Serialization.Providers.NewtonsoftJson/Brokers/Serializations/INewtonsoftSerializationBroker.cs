// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System.IO;

namespace STX.Serialization.Providers.NewtonsoftJson.Brokers.Serializations
{
    internal interface INewtonsoftSerializationBroker
    {
        void SerializeAsync<T>(StreamWriter writer, T @object);
    }
}
