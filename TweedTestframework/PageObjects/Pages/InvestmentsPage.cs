using System;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;

namespace TweedTestframework.PageObjects.Pages
{
    public class InvestmentsPage
    {
        IWebDriver driver;

        public InvestmentsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        //Object Repository or Page Factory

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement InvestmentTextOnBanner { get; set; }

        [FindsBy(How = How.LinkText, Using = "More from The Virgin Group")]
        public IWebElement MorefromTheVirginGroupLink { get; set; }


        [FindsBy(How = How.PartialLinkText, Using = "giving")]
        public IWebElement VirginMoneyGivingLink { get; set; }

        
       

        public String VerifyingInvestmentPageExists()
        {
            var actual = InvestmentTextOnBanner.Text;
            return actual;
        }


        public void ClickOnVirginMoneyGivingLink()
        {
            //MorefromTheVirginGroupLink.Click();
            String str1=MorefromTheVirginGroupLink.TagName;
            Thread.Sleep(2000);
            
            Console.WriteLine(str1);
           // VirginMoneyGivingLink.Click();

            //return new VirginMoneyGivingPage(driver);
        }
       
    }
}
