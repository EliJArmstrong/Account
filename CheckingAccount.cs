using System;


namespace Account
{
    class CheckingAccount : Account
    {
        decimal fee;

        public CheckingAccount(decimal initialBalance, decimal fee) : base(initialBalance)
        {
            if (fee >= 0)
            {
                this.fee = fee;
            }
            else
            {
                throw new Exception("Fee cannot be a negative number.");
            }
        }

        public new void Credit(decimal addMoney)
        {
            if (base.Debit(fee))
            {
                base.Credit(addMoney);
            }
        }

        public new void Debit(decimal subtractMoney)
        {
            if (base.Debit(subtractMoney))
            {
                base.Debit(fee);
            }
        }
    }
}
