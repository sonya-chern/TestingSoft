using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;


namespace TestingSoft.PageObjects
{
    public class AuthorizationPage : Form
    {
        private ITextBox LoginField => ElementFactory.GetTextBox(By.Id("inputLogin"), "LoginField");
        private ITextBox PasswordField => ElementFactory.GetTextBox(By.Id("inputPassword"), "PasswordField");
        private ITextBox ErrorPasswordTextBox => ElementFactory.GetTextBox(By.XPath("//div[@id = 'Password']//span[@id = 'helpBlock']"), "ErrorPasswordTexBox");
        private IButton EnterBtn => ElementFactory.GetButton(By.Id("loginButton"), "LoginButton");

        public AuthorizationPage() : base(By.Id("inputLogin"), "AuthorizationPage")
        {
        }

        public void FillLogin(string login) => LoginField.ClearAndType(login);

        public void FillPassword(string password) => PasswordField.ClearAndType(password);

        public void ClickEnter() => EnterBtn.ClickAndWait();

        public string GetTexFromErrorPasswordTextBox() => ErrorPasswordTextBox.Text;
    }
}
