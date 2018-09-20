using System;


namespace Account
{
    class Loan : Account
    {

        private decimal interestRate;

        public Loan(decimal initialBalance, decimal setInterest) : base(initialBalance)
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
            return Balance * interestRate;
        }
    }
}
