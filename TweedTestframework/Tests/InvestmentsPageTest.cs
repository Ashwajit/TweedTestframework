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

        [Test(Description = "Verify footer title displayed on footer panel"),Category("Functional Testing")]
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

        [Test(Description = "Click on Contactus link on Footer"),Category("Functional Testing")]
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

        [Test(Description="Click on StoreFinder link on Footer Panel"),Category("Functional Testing")]
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

        [Test(Description = "Click on Help and support link on Footer Panel"),Category("Functional Testing")]
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


        [Test(Description = "Click on Legals > link on Footer Panel"), Category("Functional Testing")]
        public void TestMethod6()
        {
            ExtentTest test = extent.CreateTest("TestMethod6").Info("Test Started");
            var expected = "Terms of use for our website";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnLegalsFooterLink();
            test.Log(Status.Info, "Legals > link clicked");
            var legalspageobj = new LegalsPage(driver);
            var actual = legalspageobj.VerifyLegalsHeading();
            test.Log(Status.Info, "Legals page is displayed with hero title- Terms of use for our website");
            Assert.AreEqual(actual, expected);
            test.Log(Status.Pass, "TestMethod6 Passed");
        }

        [Test(Description = "Click on Privacy > link on Footer Panel"), Category("Functional Testing")]
        public void TestMethod7()
        {
            ExtentTest test = extent.CreateTest("TestMethod7").Info("Test Started");
            var expected = "Virgin Money Privacy Policy";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnPrivacyFooterLink();
            test.Log(Status.Info, "Privacy > link clicked");
            var privacypageobj = new PrivacyPage(driver);
            var actual = privacypageobj.VerifyPrivacyHeading();
            test.Log(Status.Info, "Privacy page is displayed with heading- Virgin Money Privacy Policy");
            Assert.AreEqual(actual, expected);
            test.Log(Status.Pass, "TestMethod7 Passed");
        }


        [Test(Description = "Click on Privacy > link on Footer Panel"), Category("Functional Testing")]
        public void TestMethod8()
        {
            ExtentTest test = extent.CreateTest("TestMethod8").Info("Test Started");
            var expected = "About cookies and how we use them";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnCookiesFooterLink();
            test.Log(Status.Info, "Cookies > link clicked");
            var cookiespageobj = new CookiesPage(driver);
            var actual = cookiespageobj.VerifyCookiesHeading();
            test.Log(Status.Info, "Cookies page is displayed with heading- About cookies and how we use them");
            Assert.AreEqual(actual, expected);
            test.Log(Status.Pass, "TestMethod8 Passed");
        }


        [Test(Description = "Click on Feedback > link on Footer Panel"), Category("Functional Testing")]
        public void TestMethod9()
        {
            ExtentTest test = extent.CreateTest("TestMethod9").Info("Test Started");
            var expected = "We'd love to hear what you think";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnFeedbackFooterLink();
            test.Log(Status.Info, "Feedback > link clicked");
            var feedbackpageobj = new FeedbackPage(driver);
            var actual = feedbackpageobj.VerifyFeedbackHeading();
            test.Log(Status.Info, "Feedback page is displayed with h1 heading- We'd love to hear what you think");
            Assert.AreEqual(actual, expected);
            test.Log(Status.Pass, "TestMethod9 Passed");
        }

        [Test(Description = "Click on Sitemap > link on Footer Panel"), Category("Functional Testing")]
        public void TestMethod10()
        {
            ExtentTest test = extent.CreateTest("TestMethod10").Info("Test Started");
            var expected = "Sitemap";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnSitemapFooterLink();
            test.Log(Status.Info, "Sitemap > link clicked");
            var sitemappageobj = new SitemapPage(driver);
            var actual = sitemappageobj.VerifySitemapHeading();
            test.Log(Status.Info, "Sitemap page is displayed with h1 heading- Sitemap");
            Assert.AreEqual(actual, expected);
            test.Log(Status.Pass, "TestMethod10 Passed");
        }


        [Test(Description = "Click on Accessibility > link on Footer Panel"), Category("Functional Testing")]
        public void TestMethod11()
        {
            ExtentTest test = extent.CreateTest("TestMethod11").Info("Test Started");
            var expected = "Offering accessibility support for those who need it";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnAccessibilityFooterLink();
            test.Log(Status.Info, "Accessibility > link clicked");
            var accessibilitypageobj = new AccessibilityPage(driver);
            var actual = accessibilitypageobj.VerifyAccessibilityHeading();
            test.Log(Status.Info, "Accessibility page is displayed with h1 heading- Offering accessibility supports for those who need it");
            Assert.AreEqual(actual, expected);
            test.Log(Status.Pass, "TestMethod11 Passed");
        }

        [Test(Description = "Click on About us > link on Footer Panel"), Category("Functional Testing")]
        public void TestMethod12()
        {
            ExtentTest test = extent.CreateTest("TestMethod12").Info("Test Started");
            var expected = "THERE'S MONEY AND THERE'S VIRGIN MONEY";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnAboutUsFooterLink();
            test.Log(Status.Info, "About us > link clicked");
            var aboutuspageobj = new AboutUsPage(driver);
            var actual = aboutuspageobj.VerifyAboutUsHeading();
            test.Log(Status.Info, "About us page is displayed with h1 heading- Sitemap");
            Assert.AreEqual(actual, expected);
            test.Log(Status.Pass, "TestMethod12 Passed");
        }

    }
}
