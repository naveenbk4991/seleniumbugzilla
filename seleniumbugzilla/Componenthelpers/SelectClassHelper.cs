using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace seleniumbugzilla.Componenthelpers
{
    public class SelectClassHelper
    {
        private static SelectElement select;
        public static void SelectElement(By locator, int index)
        {
           select= new SelectElement(GenricHelper.GetElement(locator));
            select.SelectByIndex(index);
            
        }
        public static void SelectElement(By locator, String Visibletext)
        {
            select = new SelectElement(GenricHelper.GetElement(locator));
            select.SelectByText(Visibletext);
        }
        public static  IList<string> GetAllItem(By locator)
        {
          select =new  SelectElement(GenricHelper.GetElement(locator));
            //linqui opertion Select((x) => x.Text)
            return select.Options.Select((x) => x.Text).ToList();
        }
    }
}
