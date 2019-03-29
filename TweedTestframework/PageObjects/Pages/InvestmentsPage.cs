using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'here for you')]")]
        public IWebElement FooterTitleElement { get; set; }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement InvestmentTextOnBanner { get; set; }


        [FindsBy(How = How.LinkText, Using = "Contact us")]
        public IWebElement ContactUsFooterLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Store finder")]
        public IWebElement StoreFinderFooterLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Help and support")]
        public IWebElement HelpSupportFooterLink { get; set; }


        [FindsBy(How = How.CssSelector, Using = "a.link-chevron-right")]
        public IWebElement LegalsFooterLink { get; set; }


        [FindsBy(How = How.LinkText, Using = "Privacy policy")]
        public IWebElement PrivacyFooterLink { get; set; }


        [FindsBy(How = How.LinkText, Using = "Cookies")]
        public IWebElement CookiesFooterLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Feedback")]
        public IWebElement FeedbackFooterLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Sitemap")]
        public IWebElement SitemapFooterLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Accessibility")]
        public IWebElement AccessibilityFooterLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "About us")]
        public IWebElement AboutUsFooterLink { get; set; }

        public String VerifyingInvestmentPageExists()
        {
            var actual = InvestmentTextOnBanner.Text;
            return actual;
        }


        public String VerifyFooterTitle()
        {
            var footertitle = FooterTitleElement.Text;
            return footertitle;
        }


        public ContactPage ClickOnContactUsFooterLink()
        {
            ContactUsFooterLink.Click();
            return new ContactPage(driver);
        }

        public StoreFinderPage ClickOnStoreFinderFooterLink()
        {
            StoreFinderFooterLink.Click();
            return new StoreFinderPage(driver);
        }

        public HelpSupportPage ClickOnHelpSupportFooterLink()
        {
            HelpSupportFooterLink.Click();
            return new HelpSupportPage(driver);
        }

        public LegalsPage ClickOnLegalsFooterLink()
        {
            LegalsFooterLink.Click();
            return new LegalsPage(driver);
        }

        public PrivacyPage ClickOnPrivacyFooterLink()
        {
            PrivacyFooterLink.Click();
            return new PrivacyPage(driver);
        }


        public CookiesPage ClickOnCookiesFooterLink()
        {
            CookiesFooterLink.Click();
            return new CookiesPage(driver);
        }

        public FeedbackPage ClickOnFeedbackFooterLink()
        {
            FeedbackFooterLink.Click();
            return new FeedbackPage(driver);
        }

        public SitemapPage ClickOnSitemapFooterLink()
        {
            SitemapFooterLink.Click();
            return new SitemapPage(driver);
        }

        public AccessibilityPage ClickOnAccessibilityFooterLink()
        {
            AccessibilityFooterLink.Click();
            return new AccessibilityPage(driver);
        }

        public AboutUsPage ClickOnAboutUsFooterLink()
        {
            AboutUsFooterLink.Click();
            return new AboutUsPage(driver);
        }

    }
}
