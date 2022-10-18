using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace TestingSoft.PageObjects
{
    public class MainMenu : Form
    {
        private IButton HomeBtn => ElementFactory.GetButton(By.XPath(@"//a[contains(@class, 'home')]"), "HomeButton");
        private IButton OperationsBtn => ElementFactory.GetButton(By.XPath(@"//a[contains(@class, 'operation')]"), "OperationsButton");

        public MainMenu() : base(By.XPath(@"//a[contains(@class, 'home')]"), "mainPage")
        {
        }

        public void ClickOperations() => OperationsBtn.ClickAndWait();
    }
}
