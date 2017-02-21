using OpenQA.Selenium.Firefox;
namespace Framework.Actions.Common

{
   public class CommonActions
    {
        public static void GoToUrl()
        {
            Constant.webdriver = new FirefoxDriver();
            Constant.webdriver.Navigate().GoToUrl("http://192.168.1.11");
        }
    }
}
