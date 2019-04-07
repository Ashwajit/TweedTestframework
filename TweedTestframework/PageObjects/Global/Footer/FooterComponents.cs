using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace TweedTestframework.PageObjects.Pages
{
    public class FooterComponents
    {


        IWebDriver driver;

        public FooterComponents(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'here for you')]")]
        public IWebElement FooterTitleElement { get; set; }

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

        [FindsBy(How = How.LinkText, Using = "Careers")]
        public IWebElement CareersFooterLink { get; set; }


        [FindsBy(How = How.LinkText, Using = "Media centre")]
        public IWebElement MediaCentreFooterLink { get; set; }


        [FindsBy(How = How.LinkText, Using = "Our Lounges")]
        public IWebElement OurLoungesFooterLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Intermediaries")]
        public IWebElement IntermediariesFooterLink { get; set; }


        [FindsBy(How = How.LinkText, Using = "Investor relations")]
        public IWebElement InvestorRelationsFooterLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Gender Pay Gap")]
        public IWebElement GenderPayGapFooterLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Modern Slavery Act")]
        public IWebElement ModernSlaveryActFooterLink { get; set; }


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


        public CareersPage ClickOnCareersFooterLink()
        {
            CareersFooterLink.Click();
            return new CareersPage(driver);
        }

        public MediaCentrePage ClickOnMediaCentreFooterLink()
        {
            MediaCentreFooterLink.Click();
            return new MediaCentrePage(driver);
        }

        public OurLoungesPage ClickOnOurLoungesFooterLink()
        {
            OurLoungesFooterLink.Click();
            return new OurLoungesPage(driver);
        }


        public IntermediariesPage ClickOnIntermediariesFooterLink()
        {
            IntermediariesFooterLink.Click();
            return new IntermediariesPage(driver);
        }


        public InvestorRelationsPage ClickOnInvestorRelationsFooterLink()
        {
            InvestorRelationsFooterLink.Click();
            return new InvestorRelationsPage(driver);
        }

        public GenderPayGapPage ClickOnGenderPayGapFooterLink()
        {
            GenderPayGapFooterLink.Click();
            return new GenderPayGapPage(driver);
        }

        public ModernSlaveryActPage ClickOnModernSlaveryActFooterLink()
        {
            ModernSlaveryActFooterLink.Click();
            return new ModernSlaveryActPage(driver);
        }


    }
}
