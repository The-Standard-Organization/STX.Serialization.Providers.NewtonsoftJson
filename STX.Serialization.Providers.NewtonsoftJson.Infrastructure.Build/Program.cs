// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using STX.Serialization.Providers.NewtonsoftJson.Infrastructure.Build.Services;

namespace STX.Serialization.Providers.NewtonsoftJson.Infrastructure.Build
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            var scriptGenerationService = new ScriptGenerationService();
            scriptGenerationService.GenerateBuildScript();
        }
    }
}