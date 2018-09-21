// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>TestProgram.cs</file>
// <date>2018-09-20</date>
// <summary> This program is to be used for the testing "of the Account class
// and it's derived classes. </summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 3.5 hours. </remarks>

using System;

// ----------------------------------------------------------------------------
// The Name Space for Account.
// ----------------------------------------------------------------------------
namespace Account
{
    /// -----------------------------------------------------------------------
    /// <summary>The TestProgram class.</summary>
    /// -----------------------------------------------------------------------
    class TestProgram
    {
        /// -------------------------------------------------------------------
        /// <summary>Main entry-point for this test application.</summary>
        /// -------------------------------------------------------------------
        static void Main(string[] args)
        {
            int currentChoice = 0; // Tracks the users choice.

            Console.WriteLine("This program is to be used for the testing " +
                "of the Account class and it's derived classes.");
             Console.WriteLine();

            while (currentChoice != 5)
            {
                currentChoice = MainMenu();
                FunctionCall(currentChoice);
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>This method is to test the base Account class.</summary>
        /// -------------------------------------------------------------------
        public static void TestRegularAccount()
        {
            Account account = null; // Holds the users account.
            
            account = CreateAccount();

            Console.Clear();

            RegularAccountMenu(account);
        }

        /// -------------------------------------------------------------------
        /// <summary>This method is to test the Savings Account class.
        /// </summary>
        /// -------------------------------------------------------------------
        public static void TestSavingsAccount()
        {
            SavingsAccount savingsAccount = null; // Users savings account.

            Console.Clear();

            savingsAccount = CreateSavingsAccount();

            Console.Clear();

            SavingAccountMenu(savingsAccount);

        }

        /// -------------------------------------------------------------------
        /// <summary>This method is to test the Checking Account class.
        /// </summary>
        /// -------------------------------------------------------------------
        public static void TestCheckingAccount()
        {
            // holds users checking account
            CheckingAccount checkingAccount = null; 
            
            Console.Clear();

            checkingAccount = CreateCheckingAccount();

            Console.Clear();

            CheckingAccountMenu(checkingAccount);
            
        }

        /// -------------------------------------------------------------------
        /// <summary>This method is to test the Loan class.
        /// </summary>
        /// -------------------------------------------------------------------
        public static void TestLoan()
        {
            Loan loan = null; // Holds the users loan.
            
            Console.Clear();

            loan = CreateLoan();

            Console.Clear();
        }

        /// -------------------------------------------------------------------
        /// <summary>This method is the main menu of choices for to test the
        /// Account class and it's derived classes.</summary>
        /// 
        /// <returns>Returns an int that is the users choice given a menu
        /// </returns>
        /// -------------------------------------------------------------------
        private static int MainMenu()
        {
            int returnInt; // The return int representing the user choice.

            try
            {
                Console.WriteLine("Menu Choose an account type (1-5):");
                Console.WriteLine("1: Regular Account");
                Console.WriteLine("2: Savings Account");
                Console.WriteLine("3: Checking Account");
                Console.WriteLine("4: Loan");
                Console.WriteLine("5: Quit Program");
                Console.Write("Please enter a number: ");

                returnInt = int.Parse(Console.ReadLine());
            }
            catch
            {
                returnInt = 0;
            }

            return returnInt;
        }

        /// -------------------------------------------------------------------
        /// <summary>This method will call a function based on the users choice
        /// from the MainMenu function.</summary>
        /// 
        /// <param name="functionNumber">The number to be used in a switch 
        /// statement to call a function base on the users choice from the 
        /// MainMenu function.</param>
        /// -------------------------------------------------------------------
        private static void FunctionCall(int functionNumber)
        {
            switch (functionNumber)
            {
                case 1:
                    TestRegularAccount();
                    break;
                case 2:
                    TestSavingsAccount();
                    break;
                case 3:
                    TestCheckingAccount();
                    break;
                case 4:
                    TestLoan();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Bye Bye");
                    Console.WriteLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1-5");
                    Console.WriteLine();
                    break;

            }
        }

        /// -------------------------------------------------------------------
        /// <summary>This method creates an Account based on the initial amount 
        /// asked by this method.</summary>
        /// 
        /// <returns>An Account class with a initial amount set by the user.
        /// </returns>
        /// -------------------------------------------------------------------
        private static Account CreateAccount()
        {
            Account account = null; // An Account to be created and returned.
            // A bool to be triggered in case of any Exceptions are called.
            bool passBool = false;  

            Console.Clear();
            Console.Write("How much currency would you like to have " +
                "to start the regular account: ");

            while (!passBool)
            {
                try
                {
                    account = new Account(decimal.Parse(Console.ReadLine()));
                    passBool = true;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex);
                    Console.WriteLine();
                    Console.Write("How much currency would you like to have " +
                "to start the account: ");
                }
            }

            return account;
        }

        /// -------------------------------------------------------------------
        /// <summary>This method is the menu for the Account Class.</summary>
        /// 
        /// <param name="account">The account that will be affected by the menu
        /// </param>
        /// -------------------------------------------------------------------
        private static void RegularAccountMenu(Account account)
        {
            int currentNumber = 0; // Hold the users choice from the menu.

            while (currentNumber != 4)
            {

                Console.WriteLine("What would you like to do with the" +
                    " account:");
                Console.WriteLine("1: Deposit Money (credit method).");
                Console.WriteLine("2: Withdraw Money (debit method).");
                Console.WriteLine("3: See account balance.");
                Console.WriteLine("4: Back to main menu.");
                Console.Write("Please enter a number: ");


                try
                {
                    currentNumber = int.Parse(Console.ReadLine());
                }
                catch
                {
                    currentNumber = 0;
                }

                AccountOperation(account, currentNumber);
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>This method takes in a account and a number and proforms 
        /// an operation .</summary>
        ///
        /// -------------------------------------------------------------------
        private static void AccountOperation( Account account, int currentNumber )
        {
            switch (currentNumber)
            {
                case 1:
                    Console.Clear();
                    Console.Write("How much would you like to add to" +
                        " your account: ");
                    account.Credit(decimal.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("How much would you like to withdraw" +
                        " to your account: ");
                    account.Debit(decimal.Parse(Console.ReadLine()));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Your current balance" +
                        $" is: {account.getBalance()}");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Back to main menu:");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1-4");
                    Console.WriteLine();
                    break;
            }
        }

        private static SavingsAccount CreateSavingsAccount()
        {
            SavingsAccount savingsAccount = null;

            decimal initalAmount;
            decimal interestRate;
            bool passBool = false;
            while (!passBool)
            {
                try
                {
                    Console.Write("How much currency would you like to have " +
                                  "to start the savings account: ");

                    initalAmount = decimal.Parse(Console.ReadLine());

                    Console.Write("What is the interest rate for the " +
                        "account: ");

                    interestRate = decimal.Parse(Console.ReadLine());

                    savingsAccount =
                        new SavingsAccount(initalAmount, interestRate);
                    passBool = true;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex);
                    Console.WriteLine();
                }
            }

            return savingsAccount;
        }

        private static void SavingAccountMenu(SavingsAccount savingsAccount)
        {
            int currentNumber = 0;
            while (currentNumber != 5)
            {

                Console.WriteLine("What would you like to do with the " +
                    "saving account:");
                Console.WriteLine("1: Deposit Money (credit method).");
                Console.WriteLine("2: Withdraw Money (debit method).");
                Console.WriteLine("3: See account balance.");
                Console.WriteLine("4: See interest for the account.");
                Console.WriteLine("5: Back to main menu.");
                Console.Write("Please enter a number: ");

                try
                {
                    currentNumber = int.Parse(Console.ReadLine());
                }
                catch
                {
                    currentNumber = 0;
                }

                SavingsAccountOpterations(savingsAccount, currentNumber);

            }
        }

        private static void SavingsAccountOpterations(SavingsAccount savingsAccount, int currentNumber)
        {
            switch (currentNumber)
            {
                case 1:
                    Console.Clear();
                    Console.Write("How much would you like to add to " +
                        "your account: ");
                    savingsAccount.Credit(decimal.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("How much would you like to withdraw " +
                        "to your account: ");
                    savingsAccount.Debit(decimal.Parse(Console.ReadLine()));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Your current balance " +
                        $"is: {savingsAccount.getBalance()}");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"The calculated interest " +
                        $"for the account is:" +
                        $" {savingsAccount.CalculateInterest()}");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Back to main menu:");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1-5");
                    Console.WriteLine();
                    break;
            }
        }

        private static CheckingAccount CreateCheckingAccount()
        {

            CheckingAccount checkingAccount = null;
            decimal initalAmount;
            decimal feeAmount;

            bool passBool = false;

            while (!passBool)
            {
                try
                {
                    Console.Write("How much currency would you like to have " +
                                  "to start the checking account: ");

                    initalAmount = decimal.Parse(Console.ReadLine());

                    Console.Write("What is the fee for the " +
                        "account: ");

                    feeAmount = decimal.Parse(Console.ReadLine());

                    checkingAccount =
                        new CheckingAccount(initalAmount, feeAmount);
                    passBool = true;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex);
                    Console.WriteLine();
                }
            }

            return checkingAccount;
        }

        private static void CheckingAccountMenu(CheckingAccount checkingAccount)
        {
            int currentNumber = 0;
            while (currentNumber != 5)
            {

                Console.WriteLine("What would you like to do with the " +
                    "Checking Account:");
                Console.WriteLine("1: Deposit Money (credit method).");
                Console.WriteLine("2: Withdraw Money (debit method).");
                Console.WriteLine("3: See account balance.");
                Console.WriteLine("4: See fee for the account.");
                Console.WriteLine("5: Back to main menu.");
                Console.Write("Please enter a number: ");

                try
                {
                    currentNumber = int.Parse(Console.ReadLine());
                }
                catch
                {
                    currentNumber = 0;
                }

                CheckingAccountOpertations(checkingAccount, currentNumber);

            }
        }

        private static void CheckingAccountOpertations(CheckingAccount checkingAccount, int currentNumber)
        {
            switch (currentNumber)
            {
                case 1:
                    Console.Clear();
                    Console.Write("How much would you like to add to " +
                        "your account: ");
                    checkingAccount.Credit(decimal.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("How much would you like to withdraw " +
                        "to your account: ");
                    checkingAccount.Debit(decimal.Parse(Console.ReadLine()));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Your account balance " +
                        $"is: {checkingAccount.getBalance()}");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"The fee " +
                        $"for the account is:" +
                        $" {checkingAccount.Fee}");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Back to main menu:");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1-5");
                    Console.WriteLine();
                    break;
            }
        }

        private static Loan CreateLoan()
        {
            Loan loan  = null;
            decimal initalAmount;
            decimal interestRate;

            bool passBool = false;
            while (!passBool)
            {
                try
                {
                    Console.Write("How much currency would you like to borrow: ");

                    initalAmount = decimal.Parse(Console.ReadLine());

                    Console.Write("What is the interest rate for the " +
                        "borrowed sum: ");

                    interestRate = decimal.Parse(Console.ReadLine());

                    loan =
                        new Loan(initalAmount, interestRate);
                    passBool = true;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex);
                    Console.WriteLine();
                }
            }
            return loan;
        }

        private static void LoanMenu(Loan loan)
        {
            int currentNumber = 0;

            while (currentNumber != 5)
            {

                Console.WriteLine("What would you like to do with the " +
                    "Loan account:");
                Console.WriteLine("1: Borrow more money.");
                Console.WriteLine("2: Payback some or all the borrowed amount.");
                Console.WriteLine("3: See loan balance.");
                Console.WriteLine("4: See interest sum for the account.");
                Console.WriteLine("5: Back to main menu.");
                Console.Write("Please enter a number: ");

                try
                {
                    currentNumber = int.Parse(Console.ReadLine());
                }
                catch
                {
                    currentNumber = 0;
                }

                LoanOperation(loan, currentNumber);

            }
        }

        private static void LoanOperation(Loan loan, int currentNumber)
        {
            switch (currentNumber)
            {
                case 1:
                    Console.Clear();
                    Console.Write("How much more would you like to " +
                        "borrow: ");
                    loan.Credit(decimal.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("How much would you like to payback " +
                        "to your loan: ");
                    loan.Debit(decimal.Parse(Console.ReadLine()));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Your current loan balance " +
                        $"is: {loan.getBalance()}");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"The calculated interest " +
                        $"for the account is:" +
                        $" {loan.CalculateInterest()}");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Back to main menu:");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1-5");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
