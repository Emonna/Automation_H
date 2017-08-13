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
            ScenarioContext.Current.Pending();
        }
        
        [When(@"User enters ""(.*)"" and ""(.*)""")]
        public void WhenUserEntersAnd(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
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
