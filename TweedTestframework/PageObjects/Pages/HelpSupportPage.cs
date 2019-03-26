using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class HelpSupportPage
    {
        IWebDriver driver;

        public HelpSupportPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'here to help')]")]
        public IWebElement HelpSupportHeading { get; set; }

        public String VerifyHelpSupportHeading()
        {
            var str = HelpSupportHeading.Text;
            return str;
        }

    }
}
