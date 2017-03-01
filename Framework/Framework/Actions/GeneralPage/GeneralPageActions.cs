using Framework.Actions.Common;

namespace Framework.Actions.GeneralPage
{
    public  class GeneralPageActions:CommonActions
    {
        public string getLinkName()
        {
          return GetText("");
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
