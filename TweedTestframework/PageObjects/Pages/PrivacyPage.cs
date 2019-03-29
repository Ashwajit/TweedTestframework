using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class PrivacyPage
    {

        IWebDriver driver;

        public PrivacyPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Virgin Money Privacy Policy')]")]
        public IWebElement PrivacyHeading { get; set; }

        public String VerifyPrivacyHeading()
        {
            var str = PrivacyHeading.Text;
            return str;
        }


    }
}
