using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace TestingSoft.PageObjects
{
    public class PhysicalPersonForm : Form
    {
        private ITextBox SurnameField => ElementFactory.GetTextBox(By.XPath(@"//div[@selectedobject = 'person.Surname']//input"), "SurnameField");
        private ITextBox FirstNameField => ElementFactory.GetTextBox(By.XPath(@"//div[@selectedobject = 'person.Firstname']//input"), "FirstNameField");
        private ITextBox PersonSexDropDownList => ElementFactory.GetTextBox(By.XPath(@"//dictionary-select-control[@property-name = 'person.Sex']//a"), "PersonSexDropDownList");
        private ITextBox PersonSexInputField => ElementFactory.GetTextBox(By.XPath(@"//dictionary-select-control[@property-name = 'person.Sex']//input"), "PersonSexMField");
        private ITextBox BirthdayDateField => ElementFactory.GetTextBox(By.XPath(@"//div[contains(@class, 'col-4')]//input[@name='date']"), "BirthdayDateField");
        private ITextBox InnField => ElementFactory.GetTextBox(By.XPath(@"//input[@ng-model='person.Inn']"), "InnField");
        private ITextBox CitizenshipDropDownList => ElementFactory.GetTextBox(By.XPath(@"//dictionary-select-control[@property-name = 'person.Citizenship_Id']//a"), "CitizenshipDropDownList");
        private ITextBox CitizenshipInputField => ElementFactory.GetTextBox(By.XPath(@"//dictionary-select-control[@property-name = 'person.Citizenship_Id']//input"), "CitizenshipField");
        private ITextBox PersonBirthdayPlaceField => ElementFactory.GetTextBox(By.XPath(@"//address-control[@field-name='person.Birthplace']//input"), "PersonBirthdayPlaceField");
        private ITextBox PersonBirthdayPlaceInput => ElementFactory.GetTextBox(By.XPath(@"//textarea[@ng-model='address']"), "PersonBirthdayPlaceInput");
        private ITextBox ObjectAddressPlaceField => ElementFactory.GetTextBox(By.XPath(@"//address-control[@field-name='person.ObjectAddress']//input"), "ObjectAddressPlaceField");
        
        private IButton OkMiniFormBtn => ElementFactory.GetButton(By.XPath(@"//button[contains(@class , 'btn btn-green')]"), "OkMiniFormBtn");

        private IButton OperationsBtn => ElementFactory.GetButton(By.XPath(@"//a[contains(@class, 'operation')]"), "OperationsButton");

        public PhysicalPersonForm() : base(By.XPath(@"//div[contains(@class, 'litso')]"), "PhysicalPersonForm")
        {
        }

        public void ClickOperationsBtn() => OperationsBtn.ClickAndWait();


    }
}
