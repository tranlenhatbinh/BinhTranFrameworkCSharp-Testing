using Framework.Actions.GeneralPage;
using Framework.Actions.Common;

using System.Threading;
using OpenQA.Selenium;

namespace Framework.Actions.HomeAdmin
{
    public class HomeAdminActions:GeneralPageActions
    {
        public  void NavigateToURL()
        {
            NavigateURL();
            Login("tranlenhatbinh191988@gmail.com","123456");
        }

        public void Login(string username, string password)
        {
            EnterValue(".//*[@id='login_form']/table/tbody[1]/tr[1]/td/input", username);
            EnterValue(".//*[@id='login_form']/table/tbody[1]/tr[2]/td/input", password);
            Click(".//*[@id='login_form']/table/tbody[2]/tr/td/button");
            Thread.Sleep(8);
            
        }
    }
}
