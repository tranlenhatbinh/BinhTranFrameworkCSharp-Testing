using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Framework.Actions.Common
{
   public class CommonActions
    {
        public static IWebDriver webdriver = new FirefoxDriver();

        
        public static void GoToUrl(string URL)
        {
            webdriver.Navigate().GoToUrl(URL);
        }
    }
}
