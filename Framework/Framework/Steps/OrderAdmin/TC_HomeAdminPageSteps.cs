using System;
using TechTalk.SpecFlow;

namespace Framework.Steps.OrderAdmin
{
    [Binding]
    public class TC_HomeAdminPageSteps
    {
        [Given(@"I navigate to Home Admin page after login with valid account")]
        public void GivenINavigateToHomeAdminPageAfterLoginWithValidAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Orders link on the left menu")]
        public void WhenIClickOnOrdersLinkOnTheLeftMenu()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Orders list link displays below it")]
        public void ThenTheOrdersListLinkDisplaysBelowIt()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
