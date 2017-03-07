using OpenQA.Selenium;
using System.Configuration;

namespace Framework.Actions.Common
{
  public  class Constant
    {
        public static string URL = ConfigurationManager.AppSettings["url"];
        public static string browser = ConfigurationManager.AppSettings["browser"];
        public static string username = ConfigurationManager.AppSettings["username"];
        public static string password = ConfigurationManager.AppSettings["password"];
    }
}
