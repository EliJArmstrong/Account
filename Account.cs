// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>Account.cs</file>
// <date>2018-09-20</date>
// <summary> This class represents an bank account. With the abilities to add 
// or withdraw the balance of the account. </summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 3.5 hours. </remarks>

using System;

// ----------------------------------------------------------------------------
// The Name Space for Account.
// ----------------------------------------------------------------------------
namespace Account
{
    /// -----------------------------------------------------------------------
    /// <summary>The Account class.</summary>
    /// -----------------------------------------------------------------------
    class Account
    {
        private decimal balance; // This holds the account balance.

        /// -------------------------------------------------------------------
        /// <summary>Gets or sets the balance.</summary>
        ///
        /// <value>The balance.</value>
        /// <remarks>THe setter is a protected and the getter is public
        /// </remarks>
        /// -------------------------------------------------------------------
        public decimal Balance { get => balance;
                                 protected set => balance = value; }


        /// -------------------------------------------------------------------
        /// <summary>Constructor.</summary>
        ///
        /// <param name="initialBalance"> The initial balance for the account.
        /// </param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">If the users tries to
        /// create a class with a negative initial balance</exception>
        /// -------------------------------------------------------------------
        public Account(decimal initialBalance)
        {
            if(initialBalance >= 0)
            {
                Credit(initialBalance);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Initial balance may " +
                    "not be a negative number.");
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>This function adds to the balance.</summary>
        /// 
        /// <param name="addMoney">A decimal value to be added to the balance.
        /// </param>
        /// -------------------------------------------------------------------
        public void Credit(decimal addMoney)
        {
            if(addMoney > 0)
            {
                balance += addMoney;
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>This function subtracts from balance.</summary>
        /// 
        /// <param name="subtractMoney">A decimal value to be subtracted from 
        /// the balance.</param>
        /// 
        /// <returns>A bool if a enough in the balance to subtract from then 
        /// this with return true else false.</returns>
        /// 
        /// <remarks>A message will display if more money is withdrawn than is 
        /// in the balance.</remarks>
        /// -------------------------------------------------------------------
        public bool Debit(decimal subtractMoney)
        {
            bool returnBool = false; 

            if(Math.Abs(subtractMoney) > Balance)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
            }
            else
            {
                balance -= Math.Abs(subtractMoney);
                returnBool = true;

            }

            return returnBool;
        }


        /// -------------------------------------------------------------------
        /// <summary>returns the current balance of the account.</summary>
        /// <returns>The balance</returns>
        /// -------------------------------------------------------------------
        public decimal getBalance()
        {
            return Balance;
        }


    }
}
