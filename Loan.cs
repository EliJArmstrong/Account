// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>CheckingAccount.cs</file>
// <date>2018-09-20</date>
// <summary> This class represents an checking account. With the abilities to 
// add or withdraw the balance of the account. Also, a fee is applied with any 
// valid withdraw from the account. </summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 3.5 hours. </remarks>

using System;

// ----------------------------------------------------------------------------
// The Name Space for Account.
// ----------------------------------------------------------------------------
namespace Account
{
    /// -----------------------------------------------------------------------
    /// <summary>The Loan class with the Account class as it base.</summary>
    /// -----------------------------------------------------------------------
    class Loan : Account
    {
        // The interest rate for the loan account
        private decimal interestRate;

        /// -------------------------------------------------------------------
        /// <summary>Gets or sets the interestRate.</summary>
        ///
        /// <value>The interestRate.</value>
        /// <remarks>THe setter is a private and the getter is public
        /// </remarks>
        /// -------------------------------------------------------------------
        public decimal InterestRate {  get => interestRate;
                                       private set => interestRate = value;}

        /// -------------------------------------------------------------------
        /// <summary>Constructor.</summary>
        ///
        /// <param name="initialBalance"> The initial balance for the loan.
        /// </param>
        /// 
        /// <param name="setInterest">The interest rate for the account</param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">If the users tries to
        /// create a class with a negative initial balance or a negative 
        /// interest rate.</exception>
        /// -------------------------------------------------------------------
        public Loan(decimal initialBalance, decimal setInterest) : base(initialBalance)
        {

            if (setInterest >= 0)
            {
                InterestRate = setInterest;
            }
            else
            {
                throw new ArgumentOutOfRangeException("setInterest", 
                    "Interest rate cannot be a negative number.");
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>This method returns the calculated interest of the 
        /// Savings account.</summary>
        /// 
        /// <returns>The calculated interest as a decimal</returns>
        /// -------------------------------------------------------------------
        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}
