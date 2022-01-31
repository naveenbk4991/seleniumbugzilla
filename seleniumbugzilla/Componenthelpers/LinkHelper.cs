using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace seleniumbugzilla.Componenthelpers
{
    public class LinkHelper
    {
        private static IWebElement element;
        public static void ClickLink(By Locator)
        {
            element = GenricHelper.GetElement(Locator);
            element.Click(); 
        }
    }
}
