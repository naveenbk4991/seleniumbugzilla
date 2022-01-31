using seleniumbugzilla.Settingss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumbugzilla.Componenthelpers
{
   public  class NavigationHelper
    {
        public static void NavigatieToUrl(string Url)
        {
            Objectrepository.Driver.Navigate().GoToUrl(Url);
        }
    }
}
