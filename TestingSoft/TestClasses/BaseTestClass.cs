using Aquality.Selenium.Browsers;
using NUnit.Framework;
using TestProjectLevel2.Hooks;
using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Applications;
using TestingSoft.PageObjects;

namespace TestingSoft.TestClasses
{
    public class BaseTestClasse : TestHooks
    {
        protected ISettingsFile SettingsFile = new Startup().GetSettings();

        [SetUp]
        public void AuthorizationPage()
        {
            AqualityServices.Browser.GoTo(SettingsFile.GetValue<string>(".remoteConnectionUrl"));
            var authorizationPage = new AuthorizationPage();
            Assert.IsTrue(authorizationPage.State.WaitForDisplayed(), "Authorization page is not opened");
        }

    }
}
