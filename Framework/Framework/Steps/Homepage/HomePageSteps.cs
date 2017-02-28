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
        [Given ("I navigate to Login page Admin")]
       
        public void NavigateToHomePage()
        {
            NavigateToURL();
        }
        [Then(@"the Log in button displays")]
        public void checkHomeText()
        {
            string actualText = getLinkName();
            CheckTextDisplays("Log in", actualText);
        }

    }
}
