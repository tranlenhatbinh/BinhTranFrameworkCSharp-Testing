using TechTalk.SpecFlow;
using Framework.Actions.Common;

namespace Framework.Steps.LoginAdmin
{
    [Binding]
    
    public class LoginAdminSteps:LoginAdminPage
    {
        [Given(@"I navigate to Login Admin page")]
        public void GivenINavigateToLoginAdminPage()
        {
            NavigateURL();
        }
        
        [When(@"I login with valid account")]
        public void WhenILoginWithValidAccount()
        {
            Login(Constant.username, Constant.password);
        }
        
    }
}
