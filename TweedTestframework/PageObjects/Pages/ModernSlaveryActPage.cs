using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class ModernSlaveryActPage
    {
        IWebDriver driver;

        public ModernSlaveryActPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement ModernSlaveryActHeading { get; set; }

        public String VerifyModernSlaveryActHeading()
        {
            var str = ModernSlaveryActHeading.Text;
            return str;
        }


    }
}
