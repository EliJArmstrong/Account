using System;

namespace Account
{
    class SavingsAccount : Account
    {

        private decimal interestRate;

        public SavingsAccount(decimal initinitialBalance, decimal setInterest) : base(initinitialBalance)
        {
            if (setInterest >= 0)
            {
                interestRate = setInterest;
            }
            else
            {
                throw new ArgumentOutOfRangeException("setInterest", "Interest rate cannot be a negative number.");
            }
        }

        public decimal CalculateInterest()
        {
            return interestRate * Balance;
        }
    }
}
