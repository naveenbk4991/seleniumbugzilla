using seleniumbugzilla.Settingss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using seleniumbugzilla.Componenthelpers;
namespace seleniumbugzilla.TestScripts.HyperLink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NavigatieToUrl(Objectrepository.Config.GetWebsite());
            // IWebElement element = Objectrepository.Driver.FindElement(By.XPath("//h3[text()='Discover what we do']"));
            //element.Click();
            LinkHelper.ClickLink(By.XPath("//h3[text()='Discover what we do']"));
            LinkHelper.ClickLink(By.XPath("//button[text()='Give Feedback']"));
            TextBoxHelper.TypeInTextBox(By.Id("a33e236b-3ee1-42f6-a0cc-69aa42256b63"), Objectrepository.Config.GetUsername());


        }
    }
}
