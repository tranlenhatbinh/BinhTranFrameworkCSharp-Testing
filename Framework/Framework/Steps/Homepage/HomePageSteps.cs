using TechTalk.SpecFlow;
using Framework.Actions.HomePageActions;

namespace Framework.Steps.Homepage
{   
    [Binding]
 public class HomePageSteps:HomepageActions
    {
        //Navigate to Home page
        [Given ("I navigate to Home page")]
        public void NavigateToHomePage()
        {
            NavigateToURL("http://localhost:81");
        }

    }
}
