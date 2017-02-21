using Framework.Actions.Common;

namespace Framework.Actions.Common

{
   public class CommonActions
    {
        

        
        public static void GoToUrl()
        {
            Constant.webdriver.Navigate().GoToUrl("http://192.168.1.11");
        }
    }
}
