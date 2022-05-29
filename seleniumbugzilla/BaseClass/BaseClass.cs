
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using seleniumbugzilla.Configurations;
using seleniumbugzilla.CustomExceptions;
using seleniumbugzilla.Settingss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumbugzilla.BaseClass
{
    [TestClass]
    public class BaseClass
    {
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            return option;
        }
        private  static InternetExplorerOptions GetIEoptions()
        {
            InternetExplorerOptions Options = new InternetExplorerOptions();
            Options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            Options.EnsureCleanSession = true;
            return Options;
        }
        private static IWebDriver GetFireFoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;

        }
        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEoptions());
            return driver;

        }
        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc)

        {
            Objectrepository.Config = new AppConfigReader();
            switch (Objectrepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    Objectrepository.Driver = GetFireFoxDriver();
                    break;

                case BrowserType.Chrome:
                    Objectrepository.Driver = GetChromeDriver();
                    break;
                case BrowserType.IEExplorer:
                    Objectrepository.Driver = GetIEDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound("Driver not found " + Objectrepository.Config.GetBrowser().ToString());
            }
            Objectrepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Objectrepository.Config.GetPageloadTimeout());
            Objectrepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Objectrepository.Config.GetElementloadTimeout());
        }
        [AssemblyCleanup]
        public static void TearDown()
        {
            //if(Objectrepository.Driver  != null)
            //{
            //   Objectrepository.Driver.Close();
            //    Objectrepository.Driver.Quit();
            //}
        }
    }


}
