
using OpenQA.Selenium;
using System;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace LiveDemoSeleniumAdvanced.Tests.Forms
{
    public abstract class BasePage 

    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));

        }

        public virtual string Url { get; }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(Url); 
        }

        public void ScrollTo(IWebElement element)
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            }
        public void PageLoad()
        {
            Wait.Until(Driver => ((IJavaScriptExecutor)Driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}

