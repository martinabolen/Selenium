
using LiveDemoSeleniumAdvanced.Models;
using LiveDemoSeleniumAdvanced.Tests.Forms;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LiveDemoSeleniumAdvanced.Pages.PracticeForm
{
    [TestFixture]
    public class PracticeFormPage : BasePage
    {
        
        public PracticeFormPage(IWebDriver driver)
            : base(driver)
        {

        }

        public PractiseFormSection Popup => new PractiseFormSection(Driver);


        public IWebElement FirstName => Driver.FindElement(By.Id("firstName"));

        public IWebElement LastName => Driver.FindElement(By.Id("lastName"));

        public IWebElement Email => Driver.FindElement(By.Id("userEmail"));

        public IWebElement Checkbox => Wait.Until(d => d.FindElement(By.XPath("//*[normalize-space(text())='Female']")));

        public IWebElement PhoneNumber => Wait.Until(d => d.FindElement(By.Id("userNumber")));


        public IWebElement SubmitButton => Wait.Until(d => d.FindElement(By.Id("submit")));

        public override string Url => "http://demoqa.com/automation-practice-form";

        public void FillForm(PracticeFormModel user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Email.SendKeys(user.Email);
            Checkbox.Click();
            PhoneNumber.SendKeys(user.PhoneNumber);
            ScrollTo(SubmitButton);
            SubmitButton.Click();
        }

        public void AssertErrorBorderColor(IWebElement element, IWebElement element2)
        {
            this.PageLoad();
            Assert.AreNotEqual(element.GetCssValue("border-color"), element2.GetCssValue("border-color"));


        }

        public void AssertSuccessBorderColor(IWebElement element)
        {
            
            Assert.AreEqual(element.GetCssValue("border-color"), element.GetCssValue("border-color"));
        }


    }
}
