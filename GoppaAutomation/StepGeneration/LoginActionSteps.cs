using System;
using TechTalk.SpecFlow;


namespace GoppaAutomation
{
    [Binding]
    public class LoginActionSteps
    {
        [When(@"User Navigate to LogIn Page")]
        public void WhenUserNavigateToLogInPage()
        {
            var Login = new StepGeneration.Utils.LoginTest();
            Login.Test();
        }
        
        [When(@"User enters ""(.*)"" and ""(.*)""")]
        public void WhenUserEntersAnd(string p0, string p1)
        {
            var Login = new StepGeneration.Utils.LoginTest();
            Login.TestLogin();
        }
        
        [When(@"User LogOut from the Goppa")]
        public void WhenUserLogOutFromTheGoppa()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"LogOut is done Successfully")]
        public void ThenLogOutIsDoneSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
