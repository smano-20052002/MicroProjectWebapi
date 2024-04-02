// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
namespace Selenium
{
    [TestFixture]
    public class ViewBloodRequestTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void viewBloodRequest()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/admindashboard");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            driver.FindElement(By.CssSelector(".nav-item:nth-child(8) .d-none")).Click();
            driver.FindElement(By.CssSelector(".nav-item:nth-child(9) .d-none")).Click();
            driver.Close();
        }
    }

}