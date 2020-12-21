using System;

namespace Calculator
{
    public class CalculatorClass
    {
        public static int AccountBalance { get; set; }
        public static int WithdrawalAmount { get; set; }
        public static int RemainingBalance { get; set; }

        public CalculatorClass(int AB, int WA)
        {
            AccountBalance = AB;
            WithdrawalAmount = WA;
        }



        public int Calculate()
        {
            return RemainingBalance = AccountBalance - WithdrawalAmount;
        }

    }
}
