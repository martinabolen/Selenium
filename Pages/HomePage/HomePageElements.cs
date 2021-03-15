using LiveDemoSeleniumAdvanced.Tests.Forms;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Pages.HomePage
{
    public partial class HomePage :BasePage
    {
        public IWebElement CategoryButton(string categoryName) =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{categoryName}']/ancestor::div[@class='card-body']"));

    }
}
