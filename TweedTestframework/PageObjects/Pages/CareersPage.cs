using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class CareersPage
    {

        IWebDriver driver;

        public CareersPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement CareersHeading { get; set; }

        public String VerifyCareersHeading()
        {
            var str = CareersHeading.Text;
            return str;
        }

    }
}
