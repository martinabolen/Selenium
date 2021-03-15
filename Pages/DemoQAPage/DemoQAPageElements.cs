using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Pages
{
    public partial class DemoQAPage
    {
        public override string Url => throw new NotImplementedException();

        protected IWebElement LeftPanel => Driver.FindElement(By.XPath("//*[@class='left-pannel']"));

        public IWebElement InteractionsButton => LeftPanel.FindElement(By.XPath("//*[@class='left-pannel']//*[normalize-space(text())='Interactions']"));

        public IWebElement SubMenu(string subName) => LeftPanel.FindElement(By.XPath($".//*[normalize-space(text())='{subName}']"));

        public IWebElement PageTitle => Driver.FindElement(By.ClassName("main-header"));

    }
}

