using OpenQA.Selenium;
using seleniumbugzilla.Interfac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumbugzilla.Settingss
{
    public class Objectrepository

    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
