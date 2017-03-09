using Framework.Actions.GeneralAdminPage;

namespace Framework.Steps.LoginAdmin
{
    public class LoginAdminPage:GeneralPage
    {
        public void NavigatetoURL()
        {
            NavigateURL();
        }
        public void Login(string username, string password)
        {
            EnterValue("username textbox", username);
            EnterValue("password textbox", password);
            Click("login button");
        }

    }
}
