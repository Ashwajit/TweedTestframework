using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace TweedTestframework.PageObjects.Pages
{
    public class FooterComponentsSocialLinks
    {


        IWebDriver driver;

        public FooterComponentsSocialLinks(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

       
        [FindsBy(How = How.CssSelector, Using = "Media centre")]
        public IWebElement MediaCentreFooterLink { get; set; }



        public MediaCentrePage ClickOnMediaCentreFooterLink()
        {
            MediaCentreFooterLink.Click();
            Thread.Sleep(1000);
            return new MediaCentrePage(driver);
        }

    }
}
