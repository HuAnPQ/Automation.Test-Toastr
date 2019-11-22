using Automation.Infrastructure;
using Automation.PageModels;
using System;
using TechTalk.SpecFlow;

namespace Automation.Test.StepDefinitions
{
    [Binding]
    public class ToastJsSteps
    {

        DriverFactory factory = new DriverFactory(WebBrowser.Chrome);
        ToastPage toastPage;

        [Given(@"Im on the ToastJs")]
        public void GivenImOnTheToastJs()
        {
            this.toastPage = new ToastPage(factory);
        }
        
        [Given(@"I write ""(.*)"" as title")]
        public void GivenIWriteAsTitle(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I write ""(.*)"" as message")]
        public void GivenIWriteAsMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press the show toast")]
        public void WhenIPressTheShowToast()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the show toast title and message")]
        public void ThenTheShowToastTitleAndMessage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
