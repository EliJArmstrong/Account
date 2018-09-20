using System;

namespace Account
{
    class Account
    {
        private decimal balance;

        public decimal Balance { get => balance; protected set => balance = value; }

        public Account(decimal initialBalance)
        {
            if(initialBalance >= 0)
            {
                Credit(initialBalance);
            }
            else
            {
                throw new ArgumentOutOfRangeException("InitialBalance may not be a negative number.");
            }


        }


        public void Credit(decimal addMoney)
        {
            if(addMoney > 0)
            {
                balance += addMoney;
            }
        }

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

        public decimal getBalance()
        {
            return Balance;
        }


    }
}
