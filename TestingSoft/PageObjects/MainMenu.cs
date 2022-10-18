using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace TestingSoft.PageObjects
{
    public class MainMenu : Form
    {
        private IButton PersonsListButton => ElementFactory.GetButton(By.XPath(@"//li[@ng-show='isShow.PERSON']//a"), "PersonsListButton");
        private IButton OperationsBtn => ElementFactory.GetButton(By.XPath(@"//a[contains(@class, 'operation')]"), "OperationsButton");

        public MainMenu() : base(By.XPath(@"//a[contains(@class, 'home')]"), "mainPage")
        {
        }

        public void ClickOperationsBtn() => OperationsBtn.ClickAndWait();

        public void ClickPersonListBtn() => PersonsListButton.ClickAndWait();
    }
}
