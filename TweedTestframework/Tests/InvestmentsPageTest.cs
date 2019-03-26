using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [Test (Description ="Verifying Investment Page Exists")]
        public void TestMethod1()
        {
            
            ExtentTest test=extent.CreateTest("TestMethod1").Info("Test Started");
            String expected = "INVESTMENTS";
            var investment = new InvestmentsPage(driver);
           String actual= investment.VerifyingInvestmentPageExists();
            test.Log(Status.Info, "Investment Page Opened");
             Assert.AreEqual(expected,actual);
            test.Log(Status.Pass, "TestMethod1 Passed");
        }

        [Test(Description = "Verify footer title displayed on footer panel")]
        public void TestMethod2()
        {
            ExtentTest test = extent.CreateTest("TestMethod2").Info("Test Started");
            var expected = "We're here for you";
            var investment = new InvestmentsPage(driver);
            String actual = investment.VerifyFooterTitle();
            test.Log(Status.Info, "Footer title displayed on panel");
            Assert.AreEqual(expected, actual);
            test.Log(Status.Pass, "TestMethod2 Passed");
        }

        [Test(Description = "Click on Contactus link on Footer")]
        public void TestMethod3()
        {
            ExtentTest test = extent.CreateTest("TestMethod3").Info("Test Started");
            var expected = "Contact us";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnContactUsFooterLink();
            test.Log(Status.Info, "Contact us link clicked");
            var contactuspageobj =new ContactPage(driver);
            var actual=contactuspageobj.VerifyContactUsHeading();
            test.Log(Status.Info, "Contact us text displayed");
            Assert.AreEqual(actual, expected);
            test.Log(Status.Pass, "TestMethod3 Passed");

        }

        [Test(Description="Click on StoreFinder link on Footer Panel")]
        public void TestMethod4()
        {
            ExtentTest test = extent.CreateTest("TestMethod4").Info("Test Started");
            var expected = "A WARM WELCOME";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnStoreFinderFooterLink();
            test.Log(Status.Info, "StoreFinder link clicked");
            var storefinderpageobj = new StoreFinderPage(driver);
            var actual = storefinderpageobj.VerifyStoreFinderHeading();
            test.Log(Status.Info, "A Warm Welcome text displayed on the banner");
            Assert.AreEqual(actual, expected);
            test.Log(Status.Pass, "TestMethod4 Passed");
        }

        [Test(Description = "Click on Help and support link on Footer Panel")]
        public void TestMethod5()
        {
            ExtentTest test = extent.CreateTest("TestMethod5").Info("Test Started");
            var expected = "WE'RE HERE TO HELP";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnHelpSupportFooterLink();
            test.Log(Status.Info, "Help and support link clicked");
            var helpsupportpageobj = new HelpSupportPage(driver);
            var actual = helpsupportpageobj.VerifyHelpSupportHeading();
            test.Log(Status.Info, "Help and Support page is displayed with hero title- WE'RE HERE TO HELP");
            Assert.AreEqual(actual, expected);
            test.Log(Status.Pass, "TestMethod5 Passed");
        }
       


    }
}
