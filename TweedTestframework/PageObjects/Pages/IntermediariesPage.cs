using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class IntermediariesPage
    {
        IWebDriver driver;

        public IntermediariesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.PartialLinkText, Using = "Affordability")]
        public IWebElement AffCalculators { get; set; }

        public String VerifyAffordabilityCalculators()
        {
            var str = AffCalculators.Text;
            return str;
        }


    }
}
