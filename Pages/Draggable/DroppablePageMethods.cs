using LiveDemoSeleniumAdvanced.Tests.Forms;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Pages
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver) : base(driver)
        {

        }

        public override string Url => "https://www.demoqa.com/droppable";


    }
}
