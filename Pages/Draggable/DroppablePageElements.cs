using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Pages
{
    public partial class DroppablePage
    {
        public IWebElement DragMe => Driver.FindElement(By.Id("draggable"));

        public IWebElement DropMe => Driver.FindElement(By.Id("droppable"));

        public IWebElement AcceptSection => Driver.FindElement(By.Id("droppableExample-tab-accept"));
        public IWebElement Acceptable => Driver.FindElement(By.XPath("//div[@id='acceptable']"));

        public IWebElement NotAcceptble => Wait.Until<IWebElement>(d=>d.FindElement(By.XPath("//div[@id='notAcceptable']")));
    }
}
