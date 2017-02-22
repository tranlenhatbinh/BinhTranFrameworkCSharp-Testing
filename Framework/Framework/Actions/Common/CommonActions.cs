using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
namespace Framework.Actions.Common

{
   public class CommonActions
    {
        
        public static void GoToUrl()
        {
            // Constant.webdriver = new InternetExplorerDriver();
            /*
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"E:\geckodriver-v0.11.1-win64", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            Constant.webdriver = new FirefoxDriver(service);
            Constant.webdriver.Navigate().GoToUrl(Constant.URL);
            Constant.webdriver.Manage().Window.Maximize();*/
            /*
            Constant.webdriver = new ChromeDriver(@"E:\driver\");
            Constant.webdriver.Navigate().GoToUrl(Constant.URL);
            Constant.webdriver.Manage().Window.Maximize();*/

            Constant.webdriver = new InternetExplorerDriver(@"E:\abc\");
            Constant.webdriver.Navigate().GoToUrl(Constant.URL);
            Constant.webdriver.Manage().Window.Maximize();

        }
    }
}
