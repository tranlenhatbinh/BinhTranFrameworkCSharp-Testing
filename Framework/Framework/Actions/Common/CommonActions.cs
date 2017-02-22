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
            Constant.webdriver = new FirefoxDriver();
            Console.WriteLine("b");
            
            Constant.webdriver.Navigate().GoToUrl("http://192.168.1.11");
        }
    }
}
