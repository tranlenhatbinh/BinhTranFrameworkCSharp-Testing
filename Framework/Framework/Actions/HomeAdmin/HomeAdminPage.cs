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

        public string getOrdersLinkName()
        {
            WaitForControl("orders list link", 5);
            return GetText("orders list link");
        }

        public void clickOrderListLink()
        {
            WaitForControl("orders list link", 5);
            Click("orders list link");
        }

        public string getOrdersTitleName()
        {
            WaitForControl("orders title", 5);
            return GetText("orders title");
        }
    }
}
