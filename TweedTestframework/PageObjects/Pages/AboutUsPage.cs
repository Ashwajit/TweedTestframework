using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class AboutUsPage
    {
        IWebDriver driver;

        public AboutUsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement AboutUsHeading { get; set; }

        public String VerifyAboutUsHeading()
        {
            var str = AboutUsHeading.Text;
            return str;
        }


    }
}
