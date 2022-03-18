using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace TestProject
{
    public class Tests
    {
        private IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {

            _webDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_webDriver.Title.Contains("Google"));

            IWebElement textField = _webDriver.FindElement(By.Name("q"));
            textField.SendKeys("automation test");

            IWebElement searchKey = _webDriver.FindElement(By.Name("btnK"));
            searchKey.Click();

            Assert.That(_webDriver.Title.Contains("automation test"), "Page title does not match");

            //IList<IWebElement> elements = _webDriver.FindElements(By.TagName("p"));

        }

        [Test]
        public void Test2()
        {
            //Assert.Pass();
            /* access modifiers masking SSN
            /* providing age within ranges
            SSN ssn_ = new SSN();
            ssn_.SSN_ = "test";
            Debug.WriteLine("Test output " + ssn_.SSN_);

            ssn_.Age = 155;
            Debug.WriteLine("Test output " + ssn_.Age);

            ssn_.Age = 120;
            Debug.WriteLine("Test output " + ssn_.Age);

            */

        }


        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}