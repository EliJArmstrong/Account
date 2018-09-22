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
    /// <summary>The CheckingAccount class with the Account class as it base.
    /// </summary>
    /// -----------------------------------------------------------------------
    class CheckingAccount : Account
    {
        private decimal fee; // The fee amount for withdraws.

        /// -------------------------------------------------------------------
        /// <summary>Gets or sets the fee.</summary>
        ///
        /// <value>The fee.</value>
        /// <remarks>THe setter is a private and the getter is public
        /// </remarks>
        /// -------------------------------------------------------------------
        public decimal Fee { get => fee; private set => fee = value; }

        /// -------------------------------------------------------------------
        /// <summary>Constructor.</summary>
        ///
        /// <param name="initialBalance"> The initial balance for the account.
        /// </param>
        /// 
        /// <param name="fee">The fee for the account</param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">If the users tries to
        /// create a class with a negative initial balance or a negative 
        /// fee.</exception>
        /// -------------------------------------------------------------------
        public CheckingAccount(decimal initialBalance, decimal fee) : 
                               base(initialBalance)
        {
            if (fee >= 0)
            {
                Fee = fee;
            }
            else
            {
                throw new Exception("Fee cannot be a negative number.");
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>This function subtracts from balance.</summary>
        /// 
        /// <param name="subtractMoney">A decimal value to be subtracted from 
        /// the balance.</param>
        /// 
        /// <remarks>A message will display if more money is withdrawn than is 
        /// in the balance.
        /// 
        /// If there is enough in the balance to subtract from then the fee is 
        /// taken from the account's balance.
        /// </remarks>
        /// -------------------------------------------------------------------
        public new void Debit(decimal subtractMoney)
        {
            if (base.Debit(subtractMoney))
            {
                base.Debit(Fee);
            }
        }
    }
}
