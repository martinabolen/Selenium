using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Pages
{
    public partial class SortablePage : DemoQAPage
    {
        public SortablePage(IWebDriver driver) : base(driver)
        {

        }

        public override string Url => "https://www.demoqa.com/sortable";
    }
}
