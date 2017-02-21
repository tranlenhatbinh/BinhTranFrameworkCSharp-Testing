using TechTalk.SpecFlow;
using Framework.Actions.HomePageActions;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace Framework.Steps.Homepage
{   
    [Binding]
 public class HomePageSteps:HomepageActions
    {

        IWebDriver drivers;
        //Navigate to Home page
        [Given ("I navigate to Home page")]
        public void NavigateToHomePage()
        {
            drivers.Navigate().GoToUrl("http://192.168.1.11");
        }

    }
}
