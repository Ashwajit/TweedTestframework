using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TweedTestframework.PageObjects.Pages
{
    public class ContactPage
    {
        IWebDriver driver;

        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Contact us')]")]
        public IWebElement ContactUsHeading { get; set; }

        public String VerifyContactUsHeading()
        {
            var str=ContactUsHeading.Text;
            return str;
        }


    }
}
