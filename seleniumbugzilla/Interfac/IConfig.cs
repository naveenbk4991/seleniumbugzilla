using seleniumbugzilla.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumbugzilla.Interfac
{
    public interface IConfig
    {

        BrowserType GetBrowser();
        string GetUsername(); 
        String GetPassword();
        String GetWebsite();
        int GetPageloadTimeout();
        int GetElementloadTimeout();


    }
}
