using TechTalk.SpecFlow;
using Framework.Actions.HomePageActions;
using OpenQA.Selenium;
using Framework.Actions.Common;   
namespace Framework.Steps.Homepage
{

    [Binding]
 public class LoginPageSteps:LoginPageActions
    {

        public IWebDriver webdriver;
        //Navigate to Home page
        [Given ("I navigate to Login page Admin")]
       
        public void NavigateToHomePage()
        {
            NavigateToURL();
        }

        [When("I login to Admin Xcart site with (.*) account")]
        public void WhenILoginToAdminXCartSite(string user)
        {
            string username = "";
            string password = "";

            if (user == "valid")
            {
                username = Constant.username;
                password = Constant.password;

            }
            Login(username,password);
            
        }


        //[Then(@"the Admin site displays")]
        //public void checkHomeText()
        //{
        //    string actualText = getLinkName();
        //    CheckTextDisplays("Log in", actualText);
        //}

    }
}
