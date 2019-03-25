using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweedTestframework.PageObjects.Pages;

namespace TweedTestframework.Tests
{
    [TestFixture]
    public class InvestmentsPageTest : BaseTest
    {

        [Test (Description ="Verifying Investment Page Exists")]
        public void VerifyInvestmentPageExists()
        {

            String expected = "INVESTMENTS";
            var investment = new InvestmentsPage(driver);
           String actual= investment.VerifyingInvestmentPageExists();
             Assert.AreEqual(expected,actual);
        }

        [Test(Description = "Verify footer title displayed on footer panel")]
        public void VerifyFooterTitle()
        {

            var expected = "We're here for you";
            var investment = new InvestmentsPage(driver);
            String actual = investment.VerifyFooterTitle();
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Click on Contactus link on Footer")]
        public void ClickContactUsFooterLink()
        {
            var expected = "Contact us";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnContactUsFooterLink();
      
            var contactuspageobj =new ContactPage(driver);
            var actual=contactuspageobj.VerifyContactUsHeading();
            Assert.AreEqual(actual, expected);

        }

        [Test(Description = "Click on StoreFinder link on Footer Panel")]
        public void ClickStoreFinderFooterLink()
        {
            var expected = "A WARM WELCOME";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnStoreFinderFooterLink();

            var storefinderpageobj = new StoreFinderPage(driver);
            var actual = storefinderpageobj.VerifyStoreFinderHeading();
            Assert.AreEqual(actual, expected);

        }
       


    }
}
