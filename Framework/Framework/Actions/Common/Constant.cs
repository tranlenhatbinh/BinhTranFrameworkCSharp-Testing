using OpenQA.Selenium;
using System.Configuration;

namespace Framework.Actions.Common
{
  public  class Constant
    {
        public static IWebDriver webdriver;
        public static string URL = ConfigurationManager.AppSettings["url"];
    }
}
