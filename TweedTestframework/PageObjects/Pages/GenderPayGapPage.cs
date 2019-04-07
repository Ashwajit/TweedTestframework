using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class GenderPayGapPage
    {
        IWebDriver driver;

        public GenderPayGapPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement GenderPayGapHeading { get; set; }

        public String VerifyGenderPayGapHeading()
        {
            var str = GenderPayGapHeading.Text;
            return str;
        }


    }
}
