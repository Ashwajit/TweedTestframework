using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace TweedTestframework.PageObjects.Pages
{
    public class MediaCentrePage
    {
        IWebDriver driver;

        public MediaCentrePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement MediaCentreHeading { get; set; }

        public String VerifyMediaCentreHeading()
        {
            var str = MediaCentreHeading.Text;
            Thread.Sleep(2000);
            return str;
        }

    }
}
