using LiveDemoSeleniumAdvanced.Factories;
using LiveDemoSeleniumAdvanced.Models;
using LiveDemoSeleniumAdvanced.Pages.PracticeForm;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Tests.Forms
{
    [TestFixture]
    public class PracticeFormsTests : BaseTests
    {
        [TestFixture]
        public class PracticeFormTests : BaseTest
        {
            private PracticeFormPage _practiceFormPage;
            private PracticeFormModel _user;


            [SetUp]
            public void Setup()
            {
                Initialize();
                Driver.Navigate().GoToUrl("http://demoqa.com/automation-practice-form");
                _practiceFormPage = new PracticeFormPage(Driver);
                _user = PracticeFormFactory.Create();

            }
            [Test]
            public void MessagAfterValidFillForm()
            {
    
                _practiceFormPage.FillForm(_user);

                Assert.AreEqual("Thanks for submitting the form", _practiceFormPage.Popup.Message.Text);


            }

            [Test]
            public void ErrorAfterFillFormWithoutFirtName()
            {

                _user.FirstName = string.Empty;

                _practiceFormPage.FillForm(_user);

                _practiceFormPage.AssertErrorBorderColor(_practiceFormPage.LastName,_practiceFormPage.FirstName);

            }


            ///// [TearDown]
            ///// public void TearDown()
            ///// {
            ///// Driver.Quit();
            ///// }
        }
    }
}
