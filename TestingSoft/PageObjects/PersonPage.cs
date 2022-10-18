using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;


namespace TestingSoft.PageObjects
{
    public class PersonPage : Form
    {
        private IButton AddBtn => ElementFactory.GetButton(By.XPath("//a[contains(@class, 'add')]"), "AddButton");
        private IButton PhysicalPersonBtn => ElementFactory.GetButton(By.XPath("//a[contains(@class, 'popup-fizlitso')]"), "PhysicalPersonBtn");
        
        public PersonPage() : base(By.XPath("//a[contains(@class, 'add')]"), "PersonPage")
        {
        }

        public void ClickAddBtn() => AddBtn.ClickAndWait();

        public void ClickPhysicalPersonBtn()
        {
            PhysicalPersonBtn.State.WaitForDisplayed();
            PhysicalPersonBtn.Click();
        }
    }
}
