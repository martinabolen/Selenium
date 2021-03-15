using LiveDemoSeleniumAdvanced.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static LiveDemoSeleniumAdvanced.Tests.Forms.BaseTests;

namespace LiveDemoSeleniumAdvanced.Tests.Interactions
{
    public class Droppable : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateTo();

        }

        [Test]
        public void DropElementChangeColorofTarget_When_DragAndDropDragMe()
        {
            var ColorBefore = _droppablePage.DropMe.GetCssValue("background-color");
            Builder.DragAndDropToOffset(_droppablePage.DragMe, 180, 0).Perform();
            var ColorAfter = _droppablePage.DropMe.GetCssValue("background-color");
            Assert.AreNotEqual(ColorBefore, ColorAfter);
        }


        [Test]

        public void DropElementChangeColorAfterAcceptable()
        {

            _droppablePage.AcceptSection.Click();

            var ColorBeforeAcceptable = _droppablePage.DropMe.GetCssValue("background-color");

            var Acceptable = Driver.FindElement(By.XPath("//div[@id='acceptable']"));

            Builder.DragAndDropToOffset(_droppablePage.Acceptable, 200, 0).Perform();

   
 

            var ColorAfterAcceptable = _droppablePage.DropMe.GetCssValue("background-color");

            Assert.AreNotEqual(ColorBeforeAcceptable, ColorAfterAcceptable);
        }
    }
}

