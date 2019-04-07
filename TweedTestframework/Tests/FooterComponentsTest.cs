using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Threading;
//using System.ComponentModel;
using TweedTestframework.PageObjects.Pages;

namespace TweedTestframework.Tests
{
    [TestFixture]
    public class FooterComponentsTest : BaseTest
    {
        ExtentReports extent = null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlRepoter = new ExtentHtmlReporter(@"C:\Users\ashwajit\source\repos\TweedTestframework\TweedTestframework\ExtentReports\FooterComponentsTest.html");
            extent.AttachReporter(htmlRepoter);
        }

        [OneTimeTearDown]
        public void ExtentStop()
        {
            extent.Flush();
        }
  
        [Test(Description = "Click on all the Footer links"), Category("Functional Testing")]
        public void VerifyingAllFooterLinks()
        {

            ExtentTest test = extent.CreateTest("VerifyingFooterLinks").Info("Test Started");
            var footercomponent = new FooterComponents(driver);
            var footercomponentsociallinks = new FooterComponentsSocialLinks(driver);
            // 1.Verifying footer title  on Footer Panel

            var expectedfootertitle = "We're here for you";
            String actualfootertitle = footercomponent.VerifyFooterTitle();
            test.Log(Status.Info, "Footer title displayed on panel");
            Assert.AreEqual(actualfootertitle, expectedfootertitle);
            test.Log(Status.Pass, "Footer title test step passed");

            // 2. Verifying contact us link on Footer Panel

            var expectedcontactus = "Contact us";
            footercomponent.ClickOnContactUsFooterLink();
            test.Log(Status.Info, "Contact us link clicked");
            var contactuspageobj = new ContactPage(driver);
            var actualcontactus = contactuspageobj.VerifyContactUsHeading();
            test.Log(Status.Info, "Contact us text displayed");
            Assert.AreEqual(actualcontactus, expectedcontactus);
            test.Log(Status.Pass, "Contactus test step passed");

            
            // 3. Verifying store finder link on Footer Panel

            var expectedstorefinder = "A WARM WELCOME";
            footercomponent.ClickOnStoreFinderFooterLink();
            test.Log(Status.Info, "StoreFinder link clicked");
            var storefinderpageobj = new StoreFinderPage(driver);
            var actualstorefinder = storefinderpageobj.VerifyStoreFinderHeading();
            test.Log(Status.Info, "A Warm Welcome text displayed on the banner");
            Assert.AreEqual(actualstorefinder, expectedstorefinder);
            test.Log(Status.Pass, "Store finder test step passed");

         
            // 4. Verifying help and support link on Footer Panel

            var expectedhelpandsupport = "WE'RE HERE TO HELP";
            footercomponent.ClickOnHelpSupportFooterLink();
            test.Log(Status.Info, "Help and support link clicked");
            var helpsupportpageobj = new HelpSupportPage(driver);
            var actualhelpandsupport = helpsupportpageobj.VerifyHelpSupportHeading();
            test.Log(Status.Info, "Help and Support page is displayed with hero title- WE'RE HERE TO HELP");
            Assert.AreEqual(actualhelpandsupport, expectedhelpandsupport);
            test.Log(Status.Pass, "Help and support test step passed");

            
            // 5. Verifying legals link on Footer Panel
            var expectedlegals = "Terms of use for our website";
            footercomponent.ClickOnLegalsFooterLink();
            test.Log(Status.Info, "Legals > link clicked");
            var legalspageobj = new LegalsPage(driver);
            var actuallegals = legalspageobj.VerifyLegalsHeading();
            test.Log(Status.Info, "Legals page is displayed with hero title- Terms of use for our website");
            Assert.AreEqual(actuallegals, expectedlegals);
            test.Log(Status.Pass, "Legals test step passed");

            // 6. Verifying privacy link on Footer Panel
            var expectedprivacy = "Virgin Money Privacy Policy";
            footercomponent.ClickOnPrivacyFooterLink();
            test.Log(Status.Info, "Privacy > link clicked");
            var privacypageobj = new PrivacyPage(driver);
            var actualprivacy = privacypageobj.VerifyPrivacyHeading();
            test.Log(Status.Info, "Privacy page is displayed with heading- Virgin Money Privacy Policy");
            Assert.AreEqual(actualprivacy, expectedprivacy);
            test.Log(Status.Pass, "Privacy test step passed");
            
            // 7. Verifying Cookies link on Footer Panel
            var expectedcookie = "About cookies and how we use them";
            footercomponent.ClickOnCookiesFooterLink();
            test.Log(Status.Info, "Cookies > link clicked");
            var cookiespageobj = new CookiesPage(driver);
            var actualcookie = cookiespageobj.VerifyCookiesHeading();
            test.Log(Status.Info, "Cookies page is displayed with heading- About cookies and how we use them");
            Assert.AreEqual(actualcookie, expectedcookie);
            test.Log(Status.Pass, "Cookie test step passed");

            // 8. Verifying Feedback link on Footer Panel
            var expectedfeedback = "We'd love to hear what you think";
            footercomponent.ClickOnFeedbackFooterLink();
            test.Log(Status.Info, "Feedback > link clicked");
            var feedbackpageobj = new FeedbackPage(driver);
            var actualfeedback = feedbackpageobj.VerifyFeedbackHeading();
            test.Log(Status.Info, "Feedback page is displayed with h1 heading- We'd love to hear what you think");
            Assert.AreEqual(actualfeedback, expectedfeedback);
            test.Log(Status.Pass, "Feedback test step Passed");

            // 9. Verifying Sitemap link on Footer Panel
            var expectedsitemap = "Sitemap";
            footercomponent.ClickOnSitemapFooterLink();
            test.Log(Status.Info, "Sitemap > link clicked");
            var sitemappageobj = new SitemapPage(driver);
            var actualsitemap = sitemappageobj.VerifySitemapHeading();
            test.Log(Status.Info, "Sitemap page is displayed with h1 heading- Sitemap");
            Assert.AreEqual(actualsitemap, expectedsitemap);
            test.Log(Status.Pass, "Sitemap test step passed");

            // 10. Verifying Accessibility link on Footer Panel
            var expectedaccessibility = "Offering accessibility support for those who need it";
            footercomponent.ClickOnAccessibilityFooterLink();
            test.Log(Status.Info, "Accessibility > link clicked");
            var accessibilitypageobj = new AccessibilityPage(driver);
            var actualaccessibility = accessibilitypageobj.VerifyAccessibilityHeading();
            test.Log(Status.Info, "Accessibility page is displayed with h1 heading- Offering accessibility supports for those who need it");
            Assert.AreEqual(actualaccessibility, expectedaccessibility);
            test.Log(Status.Pass, "Accessibility test step passed");


            // 11. Verifying About us link on Footer Panel
            var expectedaboutus = "THERE'S MONEY AND THERE'S VIRGIN MONEY";
            footercomponent.ClickOnAboutUsFooterLink();
            test.Log(Status.Info, "About us > link clicked");
            var aboutuspageobj = new AboutUsPage(driver);
            var actualaboutus = aboutuspageobj.VerifyAboutUsHeading();
            test.Log(Status.Info, "About us page is displayed with h1 heading- Sitemap");
            Assert.AreEqual(actualaboutus, expectedaboutus);
            test.Log(Status.Pass, "About us test step Passed");


          //  12.Verifying Careers > link on Footer Panel
            var expectedcareers = "Welcome to Virgin Money careers";
            footercomponent.ClickOnCareersFooterLink();
            test.Log(Status.Info, "Careers > link clicked");
            var careerspageobj = new CareersPage(driver);
            var actualcareers = careerspageobj.VerifyCareersHeading();
            test.Log(Status.Info, "Careers page is displayed with h1 heading - Welcome to Virgin Money careers");
            Assert.AreEqual(actualcareers, expectedcareers);
            test.Log(Status.Pass, "Careers test step Passed");
            driver.Navigate().Back();           


            // 13. Verifying Media Centre > link on Footer Panel
            var expectedmediacentre = "Welcome to the Virgin Money Media Centre";
            footercomponent.ClickOnMediaCentreFooterLink();
            test.Log(Status.Info, "Media Centre > link clicked");
            var mediacentrepageobj = new MediaCentrePage(driver);
            var actualmediacentre = mediacentrepageobj.VerifyMediaCentreHeading();
            test.Log(Status.Info, "Media Centre page is displayed with h1 heading - ");
            Assert.AreEqual(actualmediacentre, expectedmediacentre);
            test.Log(Status.Pass, "Media Centre test step Passed");

            // 14. Verifying Our Lounges > link on Footer Panel
            var expectedourlounges = "VIRGIN MONEY LOUNGES";
            footercomponent.ClickOnOurLoungesFooterLink();
            test.Log(Status.Info, "Our Lounges > link clicked");
            var ourloungespageobj = new OurLoungesPage(driver);
            var actualourlounges = ourloungespageobj.VerifyOurLoungesHeading();
            test.Log(Status.Info, "Our Lounges page is displayed with h1 heading -VIRGIN MONEY LOUNGES ");
            Assert.AreEqual(actualourlounges, expectedourlounges);
            test.Log(Status.Pass, "Our Lounges test step Passed");

            // 15. Verifying Intermediaries > link on Footer Panel
            var expectedintermediaries = "Affordability calculator";
            footercomponent.ClickOnIntermediariesFooterLink();
            test.Log(Status.Info, "Intermediaries > link clicked");
            var intermediariespageobj = new IntermediariesPage(driver);
            var actualintermediaries = intermediariespageobj.VerifyAffordabilityCalculators();
            test.Log(Status.Info, "Intermediaries page is displayed with Affordability Calculators ");
            Assert.AreEqual(actualintermediaries, expectedintermediaries);
            test.Log(Status.Pass, "Intermediaries test step Passed");
            driver.Navigate().Back();


            // 16. Verifying Investor relations > link on Footer Panel
            var expectedinvestorrelations = "Welcome to Virgin Money Investor Relations";
            footercomponent.ClickOnInvestorRelationsFooterLink();
            test.Log(Status.Info, "Investor relations > link clicked");
            var investorrelationspageobj = new InvestorRelationsPage(driver);
            var actualinvestorrelations = investorrelationspageobj.VerifyInvestorRelationsHeading();
            test.Log(Status.Info, "Investor Relations page is displayed with Affordability Calculators ");
            Assert.AreEqual(actualinvestorrelations, expectedinvestorrelations);
            test.Log(Status.Pass, "Investor Relations test step Passed");


            // 17. Verifying Gender Pay Gap > link on Footer Panel
            var expectedgenderpaygap = "Gender balance";
            footercomponent.ClickOnGenderPayGapFooterLink();
            test.Log(Status.Info, "Gender Pay Gap > link clicked");
            var genderpaygappageobj = new GenderPayGapPage(driver);
            var actualgenderpaygap = genderpaygappageobj.VerifyGenderPayGapHeading();
            test.Log(Status.Info, "Gender Pay Gap page is displayed with Gender balance");
            Assert.AreEqual(actualgenderpaygap, expectedgenderpaygap);
            test.Log(Status.Pass, "Gender Pay Gap test step Passed");

            // 18. Verifying Gender Pay Gap > link on Footer Panel
            var expectedmodernslaveryact = "Modern Slavery Act";
            footercomponent.ClickOnModernSlaveryActFooterLink();
            test.Log(Status.Info, "Modern Slavery Act > link clicked");
            var modernslaveryactpageobj = new ModernSlaveryActPage(driver);
            var actualmodernslaveryact = modernslaveryactpageobj.VerifyModernSlaveryActHeading();
            test.Log(Status.Info, "Modern Slavery Act page is displayed with");
            Assert.AreEqual(actualmodernslaveryact, expectedmodernslaveryact);
            test.Log(Status.Pass, "Modern Slavery Act test step Passed");

        }

    }
}
