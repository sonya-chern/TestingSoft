using NUnit.Framework;
using TestingSoft.PageObjects;
using TestingSoft.Resources;
using TestingSoft.TestData;

namespace TestingSoft.TestClasses
{
    public class StateTechnicalSupervisionTest : BaseTestClasse
    {
        private readonly AuthorizationPage authorizationPage = new AuthorizationPage();
        private readonly PersonPage personPage = new PersonPage();
        private readonly MainMenu mainMenu = new MainMenu();

        [Test]
        public void CheckAuthorizationFormPositive()
        {
            LogIn(Settings.Login, Settings.Password);            
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

        [Test]
        public void CheckPersonCreationPositive()
        {
            LogIn(Settings.Login, Settings.Password);
            mainMenu.ClickOperationsBtn();
            mainMenu.ClickPersonListBtn();
            Assert.IsTrue(personPage.State.WaitForDisplayed(), "Person page is not display");
            personPage.ClickAddBtn();
            personPage.ClickPhysicalPersonBtn();
        }

        private void LogIn(string login, string password)
        {
            authorizationPage.FillLogin(login);
            authorizationPage.FillPassword(password);
            authorizationPage.ClickEnter();
        }
    }
}
