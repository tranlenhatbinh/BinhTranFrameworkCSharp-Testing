using OpenQA.Selenium;
using System.Configuration;

namespace Framework.Actions.Common
{
  public  class Constant
    {
        public static IWebDriver webdriver;
        public static string URL = ConfigurationManager.AppSettings["url"];
        public static string username = "tranlenhatbinh191988@gmail.com";
        public static string password = "123456";
    }
}
