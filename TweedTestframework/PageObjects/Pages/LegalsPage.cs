using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class LegalsPage
    {

        IWebDriver driver;

        public LegalsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement LegalsHeading { get; set; }

        public String VerifyLegalsHeading()
        {
            var str = LegalsHeading.Text;
            return str;
        }

    }

}

