using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace LiveDemoSeleniumAdvanced.Tests.Forms
{
    [TestFixture]
    public class BaseTests
    {
        [TestFixture]
        public class BaseTest
        {
            protected IWebDriver Driver { get; set; }

            protected Actions Builder { get; set; }

            public void Initialize()
            {
                Driver = new ChromeDriver();
                Builder = new Actions(Driver);
            }
        }
    }
}
