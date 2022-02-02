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
        private static IWebElement ele;
        public static void ClickButton(By locator)
        {
            ele = GenricHelper.GetElement(locator);
                ele.Click();
        }

    }
}
