using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Framework.Actions.HomeAdmin;

namespace Framework.Steps.Homepage
{

    [Binding]
 public class HomeAdminSteps : HomeAdminActions
    {

        //Navigate to Home page
        [Given ("I navigate to Home Admin page")]
       
        public void NavigateToHomeAdmin()
        {
            NavigateToURL();
        }

        [Then(@"the Orders link displays at the left side")]
        public void checkHomeText()
        {
            string actualText = getLinkName();
            CheckTextDisplays("Evaluation notice", actualText);
        }

    }
}
