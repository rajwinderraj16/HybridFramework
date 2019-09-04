using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using PomWithSingltonBase.Configuration;
using PomWithSingltonBase.SingltonDriver;

namespace PomWithSingltonBase.SingltonDriver
{
    class BaseDriver
    {
        public static IWebDriver driver = null;



        public static void Initialization()
        {
            if (driver == null)
            {
                if (Resource1.Browser.Equals("Chrome"))
                {
                    driver = new ChromeDriver();
                }
                else if (Resource1.Browser.Equals("Firefox"))
                {
                    driver = new FirefoxDriver();
                }
            }
            driver.Manage().Window.Maximize();
        }

        public static void quit()
        {
            driver.Quit();
            driver = null;
        }

        public static void close()
        {
            driver.Close();
            driver = null;
        }



        
    }


}