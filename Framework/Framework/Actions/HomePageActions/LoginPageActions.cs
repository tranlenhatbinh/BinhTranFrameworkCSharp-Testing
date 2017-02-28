using Framework.Actions.Common;
using System;
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
        }
    }
}
