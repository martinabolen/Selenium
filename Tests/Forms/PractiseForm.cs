using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Tests.Forms
{
    public class PractiseFormSection : BasePage
    {
        public PractiseFormSection(IWebDriver driver)
            :base(driver)
        {

        }
        public IWebElement Message => Wait.Until(d => d.FindElement(By.Id("example-modal-sizes-title-lg")));

        public override string Url => "http://demoqa.com/automation-practice-form";
    }
}
