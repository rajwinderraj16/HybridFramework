using NUnit.Framework;
using OpenQA.Selenium;
using PomWithSingltonBase.Configuration;
using PomWithSingltonBase.SingltonDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomWithSingltonBase.Base
{
    public class Commonclass
    {
        

        [SetUp]
        public static void startbrowser ()
            {

            BaseDriver.Initialization();
            BaseDriver.driver.Navigate().GoToUrl(Resource1.Url);
            }



        [TearDown]
        public static void closebrowser()
        {
           // BaseDriver.close();

         //BaseDriver.quit();

            ITakesScreenshot ts = (ITakesScreenshot)BaseDriver.driver;
            Screenshot scrshot= ts.GetScreenshot();
            scrshot.SaveAsFile(Resource1.screenShots, ScreenshotImageFormat.Jpeg);

        }

    }
}

