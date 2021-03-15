using AutoFixture;
using LiveDemoSeleniumAdvanced;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumLiveDemo
{
    
    class SoftUniReg
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private Fixture _fixture;
        private RegistrationUser _user;
        

    [SetUp]
    public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "http://automationpractice.com/index.php";
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            _user = UserFactory.CreateValidUser();


        }



        [Test]
        public void ValidRegistration()
        {
            {
                IWebElement SignInButton = _driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));
                SignInButton.Click();
                IWebElement EmailField = _driver.FindElement(By.CssSelector("#email_create"));
                EmailField.SendKeys("martinazboeva@abv.bg");
                IWebElement CreateAccountButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
                CreateAccountButton.Click();
                IWebElement FirstNameField = _wait.Until<IWebElement>(d => d.FindElement(By.Id("customer_firstname")));
                FirstNameField.SendKeys(_user.FirstName);
                var LastNameField = _driver.FindElement(By.Id("customer_lastname"));
                LastNameField.SendKeys(_user.LastName);
                var PasswordField = _driver.FindElement(By.Id("passwd"));
                PasswordField.SendKeys(_user.Password);
     

                var AddressField = _driver.FindElement(By.Id("address1"));
                AddressField.SendKeys("Plovdiv");
                var CityField = _driver.FindElement(By.Id("city"));
                CityField.SendKeys("Plovdiv");
                var StateField = _driver.FindElement(By.Id("id_state"));
                StateField.Click();
                var Selectedstate = new SelectElement(StateField);
                Selectedstate.SelectByText("Alabama");
                var PostalCodeField = _driver.FindElement(By.Id("postcode"));
                PostalCodeField.SendKeys(_user.PostCode);
                var MobileField = _driver.FindElement(By.Id("phone_mobile"));
                MobileField.SendKeys("0896588234");
                var RegisterButton = _driver.FindElement(By.Id("submitAccount"));
                RegisterButton.Click();
            }
        }
    [Test]
    public void AutomationRegistration()
        {
            IWebElement SignInButton = _driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));
            SignInButton.Click();
            IWebElement EmailField = _driver.FindElement(By.CssSelector("#email_create"));
            EmailField.SendKeys("martinazboeva@abv.bg");
            IWebElement CreateAccountButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
            CreateAccountButton.Click();
            IWebElement userNameField = _wait.Until<IWebElement>(d => d.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[4]/input")));
            IWebElement CreatedEmail = _driver.FindElement(By.CssSelector("#email"));
            Assert.AreEqual("martinazboeva@abv.bg", CreatedEmail.GetAttribute("value"));





        }

        [Test]
        public void FirstNegativeTestReg()
        {
            IWebElement SignInButton = _driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));
            SignInButton.Click();
            IWebElement EmailField = _driver.FindElement(By.CssSelector("#email_create"));
            EmailField.SendKeys("martinazboeva@abv.bg");
            IWebElement CreateAccountButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
            CreateAccountButton.Click();
            IWebElement FirstNameField = _wait.Until<IWebElement>(d => d.FindElement(By.Id("customer_firstname"))); 
            FirstNameField.SendKeys("Martina");
            var LastNameField = _driver.FindElement(By.Id("customer_lastname"));
            LastNameField.SendKeys("Bolen");
            var PasswordField = _driver.FindElement(By.Id("passwd"));
            PasswordField.SendKeys("123456");
            var AddressField = _driver.FindElement(By.Id("address1"));
            AddressField.SendKeys("Plovdiv");
            var CityField = _driver.FindElement(By.Id("city"));
            CityField.SendKeys("Plovdiv");
            var StateField = _driver.FindElement(By.Id("id_state"));
            StateField.Click();
            var Selectedstate = new SelectElement(StateField);
            Selectedstate.SelectByText("Alabama");
            var PostalCodeField = _driver.FindElement(By.Id("postcode"));
            PostalCodeField.SendKeys("4000");
            var MobileField = _driver.FindElement(By.Id("phone_mobile"));
            MobileField.SendKeys("0896588234");
            var RegisterButton = _driver.FindElement(By.Id("submitAccount"));
            RegisterButton.Click();
            var ErrorMessage = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div"));


            Assert.IsTrue(ErrorMessage.Text.Contains("The Zip/Postal code you've entered is invalid. It must follow this format: 00000"));




        }

        [Test]
        public void NegativeTest2()
        {
            IWebElement SignInButton = _driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));
            SignInButton.Click();
            IWebElement EmailField = _driver.FindElement(By.CssSelector("#email_create"));
            EmailField.SendKeys("martinazboeva@abv.bg");
            IWebElement CreateAccountButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
            CreateAccountButton.Click();
   
            IWebElement RegisterButton = _wait.Until<IWebElement>(d => d.FindElement(By.Id("submitAccount")));
            RegisterButton.Click();
            var ErrorMessage = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div"));

            Assert.IsTrue(ErrorMessage.Text.Contains("There are 8 errors"));
        }

        [Test]
        public void NegativeTest3()
        {
            IWebElement SignInButton = _driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));
            SignInButton.Click();
            IWebElement EmailField = _driver.FindElement(By.CssSelector("#email_create"));
            EmailField.SendKeys("martinazboeva@abv.bg");
            IWebElement CreateAccountButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
            CreateAccountButton.Click();
            IWebElement FirstNameField = _wait.Until<IWebElement>(d => d.FindElement(By.Id("customer_firstname")));
            FirstNameField.SendKeys("Martina");
            IWebElement PasswordField = _driver.FindElement(By.Id("passwd"));
            var ColorBefore = PasswordField.GetCssValue("background-color");
            PasswordField.SendKeys("00000");
            IWebElement LastNameField = _wait.Until<IWebElement>(d => d.FindElement(By.Id("customer_lastname")));
            LastNameField.Click();

            var ColorAfter =( _driver.FindElement(By.Id("passwd"))).GetCssValue("background-color");
            Assert.IsFalse(ColorBefore==ColorAfter);


        }

        [Test]
        public void NegativeTest4()
        {
            IWebElement SignInButton = _driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));
            SignInButton.Click();
            IWebElement EmailField = _driver.FindElement(By.CssSelector("#email_create"));
            EmailField.SendKeys("martinazboeva@abv.bg");
            IWebElement CreateAccountButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
            CreateAccountButton.Click();
            IWebElement LastNameField = _wait.Until<IWebElement>(d => d.FindElement(By.Id("customer_lastname")));
            LastNameField.SendKeys("11111");
            var ColorBefore = LastNameField.GetCssValue("color");
            IWebElement FirstNameField = _driver.FindElement(By.Id("customer_firstname"));
            FirstNameField.SendKeys("Martina");
            var ColorAfrer = LastNameField.GetCssValue("color");
            Assert.AreNotEqual(ColorBefore, ColorAfrer);

           

        }

        [Test]
        public void NegativeTest5()
        {
            IWebElement SignInButton = _driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));
            SignInButton.Click();
            IWebElement EmailField = _driver.FindElement(By.CssSelector("#email_create"));
            EmailField.SendKeys("martinazboeva@abv.bg");
            IWebElement CreateAccountButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
            CreateAccountButton.Click();
            IWebElement FirstNameField = _wait.Until<IWebElement>(d => d.FindElement(By.Id("customer_firstname")));
            FirstNameField.SendKeys("Martina");
            var LastNameField = _driver.FindElement(By.Id("customer_lastname"));
            LastNameField.SendKeys("Bolen");
            var PasswordField = _driver.FindElement(By.Id("passwd"));
            PasswordField.SendKeys("123456");
            var AddressField = _driver.FindElement(By.Id("address1"));
            AddressField.SendKeys("Plovdiv");
            var CityField = _driver.FindElement(By.Id("city"));
            CityField.SendKeys("Plovdiv");
            var StateField = _driver.FindElement(By.Id("id_state"));
            StateField.Click();
            var PostalCodeField = _driver.FindElement(By.Id("postcode"));
            PostalCodeField.SendKeys("00000");
            var MobileField = _driver.FindElement(By.Id("phone_mobile"));
            MobileField.SendKeys("0896588234");
            var RegisterButton = _driver.FindElement(By.Id("submitAccount"));
            RegisterButton.Click();
            var ErrorMessage = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div"));
            Assert.IsTrue(ErrorMessage.Text.Contains("This country requires you to choose a State."));
        }


        [TearDown]
    public void TearDown()
        {
            _driver.Quit();
        }
    }
}
