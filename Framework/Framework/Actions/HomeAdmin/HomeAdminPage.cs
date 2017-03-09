using Framework.Actions.GeneralAdminPage;

namespace Framework.Actions.HomeAdmin
{
    public class HomeAdminPage:GeneralPage
    {
        public void clickOrderLink()
        {
            WaitForControl("orders link", 3);
            Click("orders link");
        }

        public string getOrdersName()
        {
            WaitForControl("orders link", 5);
            return GetText("orders link");
        }
    }
}
