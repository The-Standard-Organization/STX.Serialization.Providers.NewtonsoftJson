// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace STX.Serialization.Providers.NewtonsoftJson.Brokers.Serializations
{
    internal interface INewtonsoftSerializationBroker
    {
        ValueTask SerializeAsync<T>(
            Stream utf8JsonStream,
            T @object,
            CancellationToken cancellationToken = default);
    }
}
