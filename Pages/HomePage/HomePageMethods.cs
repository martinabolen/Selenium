using LiveDemoSeleniumAdvanced.Tests.Forms;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Pages.HomePage
{
    public partial class HomePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
             
        }

        public override string Url => "http://demoqa.com";

     
    }
}
