using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using seleniumbugzilla.Settingss;

namespace seleniumbugzilla.Componenthelpers
{
   public  class GenricHelper
    {

       public static bool IsElementPresent(By Locator)
        {

            try
            {
                return Objectrepository.Driver.FindElements(Locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static IWebElement GetElement(By Locator)
        {
            if(IsElementPresent(Locator))
            
                return Objectrepository.Driver.FindElement(Locator);
                else
                    throw new NoSuchElementException("element not found " + Locator.ToString());
            
        }
    }
}
