﻿using System;
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
            string actualText = getOrdersLinkName();
            CheckTextDisplays("Orders list", actualText);
        }

        [When(@"I click on Orders list link")]
        public void WhenIClickOnOrdersListLink()
        {
            clickOrderListLink();
        }
        [Then(@"Orders page displays")]
        public void ThenOrdersPageDisplays()
        {
            string actualText = getOrdersTitleName();
            CheckTextDisplays("Orders", actualText);
        }

        [Then(@"the Home Admin page displays")]
        public void ThenTheHomeAdminPageDisplays()
        {
            string actualText = getOrdersName();
            CheckTextDisplays("Orders", actualText);
        }
    }
}
