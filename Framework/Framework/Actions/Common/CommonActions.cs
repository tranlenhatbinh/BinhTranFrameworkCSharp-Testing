using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Framework.Actions.Common

{
    public class CommonActions
    {
        public static void NavigateURL()
        {
            Webdriver.driver.Navigate().GoToUrl(Constant.URL);
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
            return Webdriver.driver.FindElement(By.XPath(xpath));
        }
    }
}
