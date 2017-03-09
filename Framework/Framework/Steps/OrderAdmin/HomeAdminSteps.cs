using System;
using TechTalk.SpecFlow;

namespace Framework.Steps.OrderAdmin
{
    [Binding]
    public class HomeAdminSteps
    {
        [When(@"I click on Orders link on the left")]
        public void WhenIClickOnOrdersLinkOnTheLeft()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Orders list link displays below it")]
        public void ThenOrdersListLinkDisplaysBelowIt()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on Orders list link")]
        public void WhenIClickOnOrdersListLink()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"Orders page displays")]
        public void ThenOrdersPageDisplays()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
