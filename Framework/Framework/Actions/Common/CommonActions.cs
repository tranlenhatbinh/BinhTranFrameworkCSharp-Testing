using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System;
namespace Framework.Actions.Common

{
   public class CommonActions
    {
        public static void GoToUrl()
        {
            // Constant.webdriver = new InternetExplorerDriver();

           // FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"E:\geckodriver-v0.11.1-win64", "geckodriver.exe");
          //  service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            Constant.webdriver = new FirefoxDriver();
            Constant.webdriver.Navigate().GoToUrl(Constant.URL);

            /*
            Constant.webdriver = new ChromeDriver(@"E:\driver\");
            Constant.webdriver.Navigate().GoToUrl(Constant.URL);
            */

            //Constant.webdriver = new InternetExplorerDriver(@"E:\abc\");
            //Constant.webdriver.Navigate().GoToUrl(Constant.URL);


        }

        public static void CheckTextDisplays(string expectedText, string actualText)
        {
            Assert.AreEqual(expectedText,actualText);
        }

        public string GetText(string xpath)
        {
            return FindWebElement(xpath).Text;
        }

        public IWebElement FindWebElement(string xpath)
        {
            return Constant.webdriver.FindElement(By.XPath(xpath));
        }
    }
}
