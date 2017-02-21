using TechTalk.SpecFlow;
using Framework.Actions.HomePageActions;
using OpenQA.Selenium;

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

    }
}
