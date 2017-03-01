using Framework.Actions.Common;

namespace Framework.Actions.GeneralPage
{
    public  class GeneralPageActions:CommonActions
    {
        public string getLinkName()
        {
          return GetText(".//*[@id='ui-id-4']");
        }

        public void EnterValue(string locator, string value)
        {
            FindWebElement(locator).Clear();
            FindWebElement(locator).SendKeys(value);
        }

        public void Click(string locator)
        {
            FindWebElement(locator).Click();
        }
    }
}
