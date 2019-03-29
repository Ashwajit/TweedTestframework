using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class FeedbackPage
    {
        IWebDriver driver;

        public FeedbackPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'love to hear what you think')]")]
        public IWebElement FeedbackHeading { get; set; }

        public String VerifyFeedbackHeading()
        {
            var str = FeedbackHeading.Text;
            return str;
        }

    }
}
