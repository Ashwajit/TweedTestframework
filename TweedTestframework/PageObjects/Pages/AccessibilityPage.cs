using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class AccessibilityPage
    {
        IWebDriver driver;

        public AccessibilityPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Offering accessibility support for those who need it')]")]
        public IWebElement AccessibilityHeading { get; set; }

        public String VerifyAccessibilityHeading()
        {
            var str = AccessibilityHeading.Text;
            return str;
        }

    }
}
