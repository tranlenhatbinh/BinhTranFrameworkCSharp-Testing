using TechTalk.SpecFlow;
using Framework.Actions.HomePageActions;
using OpenQA.Selenium;
using System;
   
namespace Framework.Steps.Homepage
{

    [Binding]
 public class HomePageSteps:HomepageActions
    {

        public IWebDriver webdriver;
        //Navigate to Home page
        [Given ("I navigate to Home page")]
       
        public void NavigateToHomePage()
        {
            NavigateToURL();
        }
        [Then(@"the Home link displays")]
        public void checkHomeText()
        {
            string actualText = HomepageActions.getLinkName();
            CheckTextDisplays("Home", actualText);
        }

    }
}
