using Framework.Actions.Common;
using System.Threading;

namespace Framework.Actions.HomePageActions
{
   public class LoginPageActions:CommonActions
    {
        public  void NavigateToURL()
        {
            GoToUrl();
        }

        public static string getLinkName()
        {
            return GetText();
        }

        public void Login(string username, string password)
        {
            FindWebElement("//form[@id='login_form']//input[@name='login']").SendKeys(username);
            FindWebElement("//form[@id='login_form']//input[@name='password']").SendKeys(password);
            FindWebElement("//form[@id='login_form']//button").Click();
           //Thread.Sleep(5);
            FindWebElement(".//*[@id='ui-id-3']/div/div/div[3]/div[2]/button[2]").Click();
        }

        public void AcceptAlert()
        {

            Constant.webdriver.SwitchTo().Alert().Dismiss();
            // Sleep 1 second after accept the alert
           
        }
    }
}
