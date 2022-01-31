using OpenQA.Selenium;
using seleniumbugzilla.Componenthelpers;
using seleniumbugzilla.Settingss;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumbugzilla.TestScripts.WebElement
{
    public class TestWebElement
    {

        public void GetElement()
        {
            NavigationHelper.NavigatieToUrl(Objectrepository.Config.GetWebsite());
            try
            {
              ReadOnlyCollection<IWebElement> col = Objectrepository.Driver.FindElements(By.TagName("input"));
                Console.WriteLine("count {0}"+col.Count());

                //Objectrepository.Driver.FindElement(By.Id("header"));
                //Objectrepository.Driver.FindElement(By.ClassName("btn"));
                //Objectrepository.Driver.FindElement(By.CssSelector("#container"));
                //Objectrepository.Driver.FindElement(By.LinkText("news/#release504"));
                //Objectrepository.Driver.FindElement(By.PartialLinkText("news"));
                //Objectrepository.Driver.FindElement(By.Name("cx"));
                //Objectrepository.Driver.FindElement(By.TagName(""));
                //Objectrepository.Driver.FindElement(By.XPath("//input[@name='cx']"));
            }
            catch(NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
            

        }

    }
}
