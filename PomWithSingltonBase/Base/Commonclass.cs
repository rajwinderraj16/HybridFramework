using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using PomWithSingltonBase.Configuration;
using PomWithSingltonBase.SingltonDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PomWithSingltonBase.Base
{
    public class Commonclass
    {



        [SetUp]
        public static void startbrowser()
        {

            BaseDriver.Initialization();
            BaseDriver.driver.Navigate().GoToUrl(Resource1.Url);
        }



        [TearDown]
        public static void closebrowser()
        {

           Thread.Sleep(2000);
           Screenshot sh = ((ITakesScreenshot)BaseDriver.driver).GetScreenshot();
           sh.SaveAsFile(Resource1.screenShots, ScreenshotImageFormat.Jpeg);

           BaseDriver.close();

            //BaseDriver.quit();



        }
       


    }
    }

