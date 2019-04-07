using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweedTestframework.PageObjects.Pages
{
    public class OurLoungesPage
    {
            IWebDriver driver;

            public OurLoungesPage(IWebDriver driver)
            {
                this.driver = driver;
                PageFactory.InitElements(driver, this);
            }

            [FindsBy(How = How.CssSelector, Using = "h1")]
            public IWebElement OurLoungesHeading { get; set; }

            public String VerifyOurLoungesHeading()
            {
                var str = OurLoungesHeading.Text;
                return str;
            }



        }
    }
