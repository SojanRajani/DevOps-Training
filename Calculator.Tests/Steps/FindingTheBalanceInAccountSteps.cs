using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Steps
{
    [Binding]
    public class FindingTheBalanceInAccountSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private static int AccountBalance { get; set; }
        private static int WithDrawAmount { get; set; }
        private static int FinalBalance { get; set; }


        public FindingTheBalanceInAccountSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"There is (.*) in my account")]
        public void GivenThereIsInMyAccount(int balance)
        {
            AccountBalance = balance;
        }

        [When(@"I withdraw (.*) from my account")]
        public void WhenIWithdrawFromMyAccount(int withdraw)
        {
            WithDrawAmount = withdraw;
        }
        
        [Then(@"The balance in my account is (.*)")]
        public void ThenTheBalanceInMyAccountIs(int finalBalance)
        {
            CalculatorClass Cal = new CalculatorClass(AccountBalance, WithDrawAmount);
            FinalBalance = Cal.Calculate();
            Assert.AreEqual(FinalBalance, finalBalance);
        }
    }
}
