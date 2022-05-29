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
     public class Flipkartlogin
    {
        [TestMethod]
        public void OpenPage() 

        {
            
            //INavigation page = Objectrepository.Driver.Navigate();
            //page.GoToUrl(Objectrepository.Config.GetWebsite());
           NavigationHelper.NavigatieToUrl(Objectrepository.Config.GetWebsite());
            Console.WriteLine(WindowHelper.GetTitle());
            //ButtonHelper.ClickButton(By.XPath("//button[@class='_2KpZ6l _2doB4z']"));
            //GenricHelper.TakeScreeenshot();
            //GenricHelper.TakeScreeenshot("test.png");


            try
            {
                ButtonHelper.ClickButton(By.XPath("//a[text()='Login']/.."));
            }
            catch (ElementClickInterceptedException e)
            {
                Console.WriteLine(e);
            }
            TextBoxHelper.TypeInTextBox(By.XPath("//input[@class='_2IX_2- VJZDxU']"), Objectrepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.XPath("//input[ @type='password']"), Objectrepository.Config.GetPassword());
            Console.WriteLine("enabled: {0}", ButtonHelper.IsButtonEnabled(By.XPath("//button[ @type='submit' and @class='_2KpZ6l _2HKlqd _3AWRsL']")));
            Console.WriteLine("TeXtbox text: {0}", ButtonHelper.GetButtonText(By.XPath("//button[ @type='submit' and @class='_2KpZ6l _2HKlqd _3AWRsL']")));
            ButtonHelper.ClickButton(By.XPath("//button[ @type='submit' and @class='_2KpZ6l _2HKlqd _3AWRsL']"));
            TextBoxHelper.TypeInTextBox(By.XPath("//input[@placeholder='Search for products, brands and more']"),"Mobiles");


            //SelectClassHelper.SelectElement(By.XPath(""), 2);
            //SelectClassHelper.SelectElement(By.XPath(""), "blocker");
        }
    }
}
