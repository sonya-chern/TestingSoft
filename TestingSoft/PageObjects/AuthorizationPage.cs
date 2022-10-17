using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;


namespace TestingSoft.PageObjects
{
    public class AuthorizationPage : Form
    {
        private ITextBox LoginField => ElementFactory.GetTextBox(By.XPath("//input[@id='inputLogin']"), "LoginField");
        private ITextBox PasswordField => ElementFactory.GetTextBox(By.XPath("//input[@id='inputPassword']"), "PasswordField");

        public AuthorizationPage() : base(By.XPath(@"//input[@id='inputLogin']"), "mainPage")
        {
        }

        public void FillLogin(string login) => LoginField.ClearAndType(login);
    }
}
