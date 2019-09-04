using PomWithSingltonBase.Base;
using PomWithSingltonBase.PageObjects;
using PomWithSingltonBase.SingltonDriver;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PomWithSingltonBase
{
    [Binding]

    
    public class LoginSteps:Commonclass
    {
        LoginPage LP = new LoginPage();
        [Given(@"user enter the username")]
        
        public void GivenUserEnterTheUsername()
        {

            Commonclass.startbrowser();
            Thread.Sleep(2000);
            LP.user();

        }
        
        [Given(@"user enter the passowrd")]
        public void GivenUserEnterThePassowrd()
        {
            Thread.Sleep(2000);
            LP.Pass();
        }
        
        [When(@"user click on the save button")]
        public void WhenUserClickOnTheSaveButton()
        {
            Thread.Sleep(2000);
            LP.Logbtn();
        }

        [Then(@"the he directed to the home page")]
        public void ThenTheHeDirectedToTheHomePage()
        {

        }

    }
}
