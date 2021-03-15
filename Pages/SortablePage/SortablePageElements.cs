using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Pages
{
    public partial class SortablePage
    {
        public List<IWebElement> listofOptions => Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]")).ToList();

        public IWebElement Container => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div"));
    }
}
