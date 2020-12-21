using System;

namespace Calculator
{
    class Program
    {
        public static int AccountBalance { get; set; }
        public static int WithdrawalAmount { get; set; }
        public static int RemainingBalance { get; set; }

        public Program(int AB, int WA)
        {
            AccountBalance = AB;
            WithdrawalAmount = WA;
        }

        public static int Calculate()
        {
            return RemainingBalance = AccountBalance - WithdrawalAmount;
        }

    }
}
