using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
//using System.ComponentModel;
using TweedTestframework.PageObjects.Pages;

namespace TweedTestframework.Tests
{
    [TestFixture]
    public class InvestmentsPageTest : BaseTest
    {
        ExtentReports extent = null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlRepoter = new ExtentHtmlReporter(@"C:\Users\ashwajit\source\repos\TweedTestframework\TweedTestframework\ExtentReports\InvestmentsPageTest.html");
            extent.AttachReporter(htmlRepoter);
        }

        [OneTimeTearDown]
        public void ExtentStop()
        {
            extent.Flush();
        }

        [Test (Description ="Verifying Investment page exists"),Category("Smoke Testing"),Category("Functional Testing")]
        public void VerifyInvestmentsPageExists()
        {
            
            ExtentTest test=extent.CreateTest("TestMethod1").Info("Test Started");
            String expected = "INVESTMENTS";
            var investment = new InvestmentsPage(driver);
           String actual= investment.VerifyingInvestmentPageExists();
            test.Log(Status.Info, "Investment Page Opened");
             Assert.AreEqual(expected,actual);
            test.Log(Status.Pass, "TestMethod1 Passed");
        }

        

    }
}
