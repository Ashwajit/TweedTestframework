using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TweedTestframework
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://uk.virginmoney.com/virgin/splash/investments.jsp");
            Thread.Sleep(1000);
        }

        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }

    }
}
