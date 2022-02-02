using Microsoft.VisualStudio.TestTools.UnitTesting;
using seleniumbugzilla.Settingss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using System.Threading.Tasks;
using OpenQA.Selenium;
using seleniumbugzilla.Componenthelpers;
using OpenQA.Selenium.Interactions;

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
            try
            {
                ButtonHelper.ClickButton(By.XPath("//a[text()='Login']/.."));
            }
            catch (ElementClickInterceptedException e)
            {
                Console.WriteLine(e);
            }
            TextBoxHelper.TypeInTextBox(By.XPath("//input[ @class='_2IX_2- VJZDxU']"), Objectrepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.XPath("//input[ @type='password']"), Objectrepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.XPath("//button[ @type='submit' and @class='_2KpZ6l _2HKlqd _3AWRsL']"));
        }
    }
}
