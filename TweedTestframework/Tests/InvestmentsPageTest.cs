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

        [Test (Description ="Checking Investment Page Exists")]
        public void TestMethod1()
        {

            String expected = "INVESTMENTS";
            var investment = new InvestmentsPage(driver);
           String actual= investment.VerifyingInvestmentPageExists();
             Assert.AreEqual(expected,actual);
        }

        [Test(Description = "Verify footer title displayed on the footer")]
        public void TestMethod2()
        {

            var expected = "We're here for you";
            var investment = new InvestmentsPage(driver);
            String actual = investment.VerifyFooterTitle();
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Click on Contactus link on Footer")]
        public void TestMethod3()
        {
            var expected = "Contact us";
            var investment = new InvestmentsPage(driver);
            investment.ClickOnContactUsFooterLink();
      
            var contactuspageobj =new ContactPage(driver);
            var actual=contactuspageobj.VerifyContactUsHeading();
            Assert.AreEqual(actual, expected);

        }

        [Test(Description = "Click on StoreFinder link on Footer Panel")]
        public void TestMethod4()
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
