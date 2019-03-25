using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class StoreFinderPage
    {
         
        IWebDriver driver;

        public StoreFinderPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'A warm welcome')]")]
        public IWebElement StoreFinderHeading { get; set; }

        public String VerifyStoreFinderHeading()
        {
            var str = StoreFinderHeading.Text;
            return str;
        }


    }

}

