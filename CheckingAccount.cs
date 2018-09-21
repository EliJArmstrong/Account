using System;


namespace Account
{
    class CheckingAccount : Account
    {
        private decimal fee;

        public decimal Fee { get => fee; private set => fee = value; }

        public CheckingAccount(decimal initialBalance, decimal fee) : base(initialBalance)
        {
            if (fee >= 0)
            {
                this.Fee = fee;
            }
            else
            {
                throw new Exception("Fee cannot be a negative number.");
            }
        }

        public new void Credit(decimal addMoney)
        {
                base.Credit(addMoney);
        }

        public new void Debit(decimal subtractMoney)
        {
            if (base.Debit(subtractMoney))
            {
                base.Debit(Fee);
            }
        }
    }
}
