using System;
using TechTalk.SpecFlow;
using Framework.Actions.HomeAdmin;

namespace Framework.Steps.OrderAdmin
{
    [Binding]
    public class HomeAdminSteps:HomeAdminPage
    {
        [When(@"I click on Orders link on the left")]
        public void WhenIClickOnOrdersLinkOnTheLeft()
        {
            clickOrderLink();
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

        [Then(@"the Home Admin page displays")]
        public void ThenTheHomeAdminPageDisplays()
        {
            string actualText = getOrdersName();
            CheckTextDisplays("Orders", actualText);
        }
    }
}
