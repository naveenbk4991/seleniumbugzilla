using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using seleniumbugzilla.Settingss;

namespace seleniumbugzilla.Componenthelpers
{
    public  class WindowHelper
    {
        public static string GetTitle()
        {
            return Objectrepository.Driver.Title;

        }

    }
}
