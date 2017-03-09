using System;
using System.Collections.Generic;
using Framework.Actions.Common;
using OpenQA.Selenium;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Web.Script.Serialization;

namespace Framework.Actions.GeneralAdminPage
{
    public class GeneralPage:CommonActions
    {
        public string GetText(string locator)
        {
            return FindWebElement(locator).Text;
        }

        /// <summary>
        /// Method to wait for control by json
        /// </summary>

        public void WaitForControl(string locator, int timeoutInSeconds)
        {
            IWebElement element;
            bool check = false;
            for (int i = 0; i < timeoutInSeconds; i++)
            {
                try
                {
                    element = FindWebElement(locator);
                    if (element.Displayed != check)
                    {
                        Sleep(1);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Sleep(1);
                    continue;
                }
            }
        }

        public void Sleep(int second)
        {
            Thread.Sleep(second * 1000);
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


        ///<summary>
        /// Method to get the class name from a method
        ///</summary>
        private static string GetClassCaller(int level = 4)
        {
            var m = new StackTrace().GetFrame(level).GetMethod();
            string className = m.DeclaringType.Name;
            return className;
        }
        public class control
        {
            public string controlName { get; set; }
            public string type { get; set; }
            public string value { get; set; }
        }

        ///<summary>
        /// Method to get value of a control from json
        ///</summary>
        public string[] GetControlValue(string nameControl)
        {
            string page = GetClassCaller();
            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
            path = path.Replace("\\bin\\Debug", "");
            string content = string.Empty;
            switch (page)
            {
                case "LoginAdminPage":
                    content = File.ReadAllText(path + @"\Interfaces\" + page + ".json");
                    break;
                case "HomeAdminPage":
                    content = File.ReadAllText(path + @"\Interfaces\" + page + ".json");
                    break;
                default:
                    break;
            }
            var result = new JavaScriptSerializer().Deserialize<List<control>>(content);
            string[] control = new string[2];
            foreach (var item in result)
            {
                if (item.controlName.Equals(nameControl))
                {
                    control[0] = item.type;
                    control[1] = item.value;
                    return control;
                }
            }
            return null;
        }

        ///<summary>
        /// Method to find a web element
        ///</summary>
        public IWebElement FindWebElement(string locator)
        {
            string[] control = GetControlValue(locator);
            switch (control[0].ToUpper())
            {
                case "ID":
                    return Webdriver.driver.FindElement(By.Id(control[1]));
                case "NAME":
                    return Webdriver.driver.FindElement(By.Name(control[1]));
                case "CLASSNAME":
                    return Webdriver.driver.FindElement(By.ClassName(control[1]));
                default:
                    return Webdriver.driver.FindElement(By.XPath(control[1]));
            }
        }
    }
}
