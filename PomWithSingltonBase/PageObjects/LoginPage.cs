using OpenQA.Selenium;
using PomWithSingltonBase.Base;
using PomWithSingltonBase.SingltonDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomWithSingltonBase.PageObjects
{
   public class LoginPage:Commonclass
    {
       
        public LoginPage()

        {
           
        }
        
        IWebElement UserName => BaseDriver.driver.FindElement(By.XPath(" //input[@name='UserName']"));
        IWebElement Password => BaseDriver.driver.FindElement(By.XPath("//input[@name='Password']"));

        IWebElement Loginbtn => BaseDriver.driver.FindElement(By.XPath("//input[@name='Login']"));

        public void user()
        {
            UserName.SendKeys("Raj");

        }

        public void Pass()
        {
           
        Password.SendKeys("12345");
           
        }

        public void Logbtn()
        {

            Loginbtn.Click();

        }

    }
}
