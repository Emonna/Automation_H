using System;
using TechTalk.SpecFlow;

namespace GoppaAutomation
{
    [Binding]
    public class StepByStepJourneySteps
    {
        [Given(@"New user is loged in  Successfully")]
        public void GivenNewUserIsLogedInSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Login is done  Successfully")]
        public void GivenLoginIsDoneSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"User selects ""(.*)""")]
        public void WhenUserSelects(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"User scroll to ""(.*)"" part")]
        public void WhenUserScrollToPart(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"User selects ""(.*)"" button")]
        public void WhenUserSelectsButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"new page ""(.*)"" is clickable")]
        public void ThenNewPageIsClickable(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"new page ""(.*)"" is uploaded")]
        public void ThenNewPageIsUploaded(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
