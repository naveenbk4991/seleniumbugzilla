using Microsoft.VisualStudio.TestTools.UnitTesting;
using seleniumbugzilla.Settingss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using System.Threading.Tasks;
using OpenQA.Selenium;
using seleniumbugzilla.Componenthelpers;

namespace seleniumbugzilla.TestScripts.PageNavgiation
{

    [TestClass]
     public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()

        {
            //INavigation page = Objectrepository.Driver.Navigate();
            //page.GoToUrl(Objectrepository.Config.GetWebsite());
           NavigationHelper.NavigatieToUrl(Objectrepository.Config.GetWebsite());
        }
    }
}
