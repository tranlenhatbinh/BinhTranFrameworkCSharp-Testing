using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace Framework.Actions.Common
{
    public class BrowserManager
    {
        public void OpenBrowser(string browsername)
        {
            switch(browsername.ToUpper())
            {
                case "FIREFOX":
                    Webdriver.driver = new FirefoxDriver();
                    Webdriver.driver.Manage().Window.Maximize();
                    break;
                case "CHROME":
                    Webdriver.driver = new ChromeDriver();
                    Webdriver.driver.Manage().Window.Maximize();
                    break;
                case "IE":
                    Webdriver.driver = new InternetExplorerDriver();
                    Webdriver.driver.Manage().Window.Maximize();
                    break;
                default:
                    Webdriver.driver = new FirefoxDriver();
                    Webdriver.driver.Manage().Window.Maximize();
                    break;
            }
        }
    }
}
