using System;
using TechTalk.SpecFlow;

namespace Framework.Steps.LoginAdmin
{
    [Binding]
    public class LoginAdminSteps
    {
        [Given(@"I navigate to Login Admin page")]
        public void GivenINavigateToLoginAdminPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I login with valid account")]
        public void WhenILoginWithValidAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Home Admin page displays")]
        public void ThenTheHomeAdminPageDisplays()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
