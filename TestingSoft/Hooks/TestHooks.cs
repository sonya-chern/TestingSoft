using Aquality.Selenium.Browsers;
using NUnit.Framework;

namespace TestProjectLevel2.Hooks
{
    public class TestHooks
    {
        [SetUp, Order(0)]
        protected static void Setup()
        {
            AqualityServices.Browser.Maximize();
        }

        [TearDown]
        protected static void Teardown()
        {
            AqualityServices.Browser.Quit();
        }
    }
}