using LiveDemoSeleniumAdvanced.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static LiveDemoSeleniumAdvanced.Tests.Forms.BaseTests;

namespace LiveDemoSeleniumAdvanced.Tests.Interactions
{
    [TestFixture]
    public class Sortable : BaseTest
    {
        private SortablePage _sortablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _sortablePage = new SortablePage(Driver);
            _sortablePage.NavigateTo();
        }

        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropUnderOtherOption()
        {
            //Arange
            var index = 1;
            //Act
            Builder.DragAndDropToOffset(_sortablePage.listofOptions[index], 0, 50).Perform();
            //Assert
            _sortablePage.AssertTextByIndex("Four", index + 1);

        }

        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropOverOtherOption()
        {
            //Arange
            var index = 4;
            //Act
            Builder.DragAndDropToOffset(_sortablePage.listofOptions[index], 100, 50).Perform();
            //Assert
            _sortablePage.AssertTextByIndex("Five", index - 1);

        }

        [Test]
        public void AllOptionsAreOrdered_When_DragAndDropSingleOption()
        {
            Builder.DragAndDropToOffset(_sortablePage.listofOptions[4], 100, 50).Perform();

            Assert.IsTrue(_sortablePage.listofOptions.All(o => o.Location.X == _sortablePage.Container.Location.X));

        }
    }
}