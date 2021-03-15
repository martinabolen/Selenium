using LiveDemoSeleniumAdvanced.Pages;
using LiveDemoSeleniumAdvanced.Pages.HomePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using static LiveDemoSeleniumAdvanced.Tests.Forms.BaseTests;

namespace LiveDemoSeleniumAdvanced
{
    [TestFixture]
    public class Navigation :BaseTest
    {
        private HomePage _homePage;
        private DemoQAPage _demoQaPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _homePage = new HomePage(Driver);
            _demoQaPage = new DemoQAPage(Driver);
            _homePage.NavigateTo();


        }


        [Test]
        [TestCase("Sortable")]
      
        public void NavigationToInteraction(string sectionName)
        {
           
            _demoQaPage.ScrollTo(_homePage.CategoryButton("Interactions"));
            _homePage.CategoryButton("Interactions").Click();

            _demoQaPage.ScrollTo(_demoQaPage.SubMenu(sectionName));
            _demoQaPage.SubMenu(sectionName).Click();

       
   
            Assert.AreEqual(sectionName, _demoQaPage.PageTitle.Text);
        }


        [Test]
        public void TestTest()
        {
            var Option = Driver.FindElement(By.XPath("//*[normalize-space(text())='Interactions']"));
            Driver.ScrollTo(Option);
            Option.Click();
            var SecondOption = Driver.FindElement(By.XPath("//*[normalize-space(text())='Droppable']//ancestor::li[@id='item-3']"));
            Driver.ScrollTo(SecondOption);
            SecondOption.Click();
            var ThirdOption = Driver.FindElement(By.XPath("//a[@id='droppableExample-tab-revertable']"));
            ThirdOption.Click();
        }
    }
}