using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class CookiesPage
    {
        IWebDriver driver;

        public CookiesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'About cookies and how we use them')]")]
        public IWebElement CookiesHeading { get; set; }

        public String VerifyCookiesHeading()
        {
            var str = CookiesHeading.Text;
            return str;
        }


    }
}
