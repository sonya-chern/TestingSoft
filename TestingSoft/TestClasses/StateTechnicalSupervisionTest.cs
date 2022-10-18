using NUnit.Framework;
using TestingSoft.PageObjects;
using TestingSoft.Resources;
using TestingSoft.TestData;

namespace TestingSoft.TestClasses
{
    public class StateTechnicalSupervisionTest : BaseTestClasse
    {
        private readonly AuthorizationPage authorizationPage = new AuthorizationPage();
        private readonly MainMenu mainMenu = new MainMenu();

        [Test]
        public void CheckAuthorizationFormPozitive()
        {
            authorizationPage.FillLogin(Settings.Login);
            authorizationPage.FillPassword(Settings.Password);
            authorizationPage.ClickEnter();
            Assert.IsTrue(mainMenu.State.WaitForDisplayed(), "Authorization is not passed");
        }

        [Test]
        public void CheckAuthorizationFormNegative()
        {            
            authorizationPage.ClickEnter();
            Assert.IsFalse(mainMenu.State.WaitForDisplayed(), "Authorization is passed");
            var actualTextFromError = authorizationPage.GetTexFromErrorPasswordTextBox();
            Assert.AreEqual(TestDataConfig.errorMessage, actualTextFromError, 
                $"Expected error message: {TestDataConfig.errorMessage} but was {actualTextFromError}");
        }
    }
}
