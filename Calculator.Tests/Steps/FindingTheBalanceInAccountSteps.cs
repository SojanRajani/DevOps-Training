using System;
using Calculator;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Steps
{
    [Binding]
    public class FindingTheBalanceInAccountSteps
    {
        public static int AccountBalance { get; set; }
        public Calculator. Cal { get; set; }
        public FindingTheBalanceInAccountSteps()
        { 
        
        }

        [When(@"I withdraw (.*) from my account")]
        public void WhenIWithdrawFromMyAccount(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The balance in my account is (.*)")]
        public void ThenTheBalanceInMyAccountIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
