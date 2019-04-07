using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class InvestorRelationsPage
    {
        IWebDriver driver;

        public InvestorRelationsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement InvestorRelationsHeading { get; set; }

        public String VerifyInvestorRelationsHeading()
        {
            var str = InvestorRelationsHeading.Text;
            return str;
        }


    }
}
