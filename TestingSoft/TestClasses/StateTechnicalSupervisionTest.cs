using NUnit.Framework;
using TestingSoft.PageObjects;

namespace TestingSoft.TestClasses
{
    public class StateTechnicalSupervisionTest : BaseTestClasse
    {
        private readonly AuthorizationPage authorizationPage = new AuthorizationPage();

        [Test]
        public void CheckAuthorizationForm()
        {
            authorizationPage.FillLogin("TEST");
        }
    }
}
