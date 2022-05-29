using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace seleniumbugzilla.Componenthelpers
{
    public class ButtonHelper

    {
        private static IWebElement element;
        public static void ClickButton(By locator)
        {
            element = GenricHelper.GetElement(locator);
                element.Click();
        }
        public static bool IsButtonEnabled(By locator)
        {
            element = GenricHelper.GetElement(locator);
            return element.Enabled;
        }
        public static string GetButtonText(By locator)
        {
            element = GenricHelper.GetElement(locator);
            if (element.GetAttribute("class") == null)
                return string.Empty;
            return element.GetAttribute("class");
        }

    }
}
