using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
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
        public static void TakeScreeenshot(string filename="Screen")
        {
           Screenshot screen=Objectrepository.Driver.TakeScreenshot();
            if(filename.Equals("Screen"))
            {
                filename= filename + DateTime.UtcNow.ToString("yyy-MM-dd-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename,ScreenshotImageFormat.Jpeg);
                return;
            }
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
        }
    }
}
