using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using seleniumbugzilla.Configurations;
using seleniumbugzilla.Interfac;
using System;
using System.Configuration;

namespace seleniumbugzilla



{
    [TestClass]
    public class UnitTest1
    {
       // private double time_in_seconds;

        [TestMethod]
        public void TestMethod1()
        {
            //IConfig config = new AppConfigReader();
            //Console.WriteLine("Browser : {0}", config.GetBrowser());
            //Console.WriteLine("username : {0}", config.GetUsername());
            //Console.WriteLine("password :{0} ", config.GetPassword());
            Console.WriteLine("test");
        }
    }
    }


