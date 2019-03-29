using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class SitemapPage
    {
        IWebDriver driver;

        public SitemapPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Sitemap')]")]
        public IWebElement SitemapHeading { get; set; }

        public String VerifySitemapHeading()
        {
            var str = SitemapHeading.Text;
            return str;
        }

    }
}
