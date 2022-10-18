using Microsoft.Extensions.Configuration;

namespace TestingSoft.TestData
{
    public static class TestDataConfig
    {
        public static string errorMessage = Configuration["errorMessageNoLogNoPass"];
        private const string pathToTestData = @"TestData\testData.json";

        public static IConfiguration Configuration => new ConfigurationBuilder().AddJsonFile(pathToTestData).Build();
    }
}
