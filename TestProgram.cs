using System;


namespace Account
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            int currentChoice = 0;

            Console.WriteLine("This program is to be used for the testing " +
                "of the Account class and it's derived classes.");

            Console.WriteLine();

            while (currentChoice != 5)
            {
                try
                {
                    Console.WriteLine("Menu Choose an account type (1-5):");
                    Console.WriteLine("1: Regular Account");
                    Console.WriteLine("2: Savings Account");
                    Console.WriteLine("3: Checking Account");
                    Console.WriteLine("4: Loan");
                    Console.WriteLine("5: Quit Program");
                    Console.Write("Please enter a number: ");

                    currentChoice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Please enter number.");
                    Console.WriteLine();
                    continue;
                }

                switch (currentChoice)
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
                        Console.WriteLine($"{currentChoice} is not option" +
                            $" please try again.");
                        Console.WriteLine();
                        break;

                }
            }
            

        }

        public static void TestRegularAccount()
        {
            Account account = null;
            bool passBool = false;
            int currentNumber = 0;

            Console.Clear();
            Console.Write("How much currency would you like to have " +
                "to start the regular account: ");

            while (!passBool)
            {
                try
                {
                    account = new Account(int.Parse(Console.ReadLine()));
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


            Console.Clear();

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
                    Console.Clear();
                    Console.WriteLine("Please enter number.");
                    Console.WriteLine();
                    continue;
                }

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
                        Console.WriteLine($"{currentNumber} is not option" +
                            $" please try again.");
                        Console.WriteLine();
                        break;
                }

            }
        }

        public static void TestSavingsAccount()
        {
            SavingsAccount savingsAccount = null;
            decimal initalAmount;
            decimal interestRate;

            bool passBool = false;
            int currentNumber = 0;

            Console.Clear();

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


            Console.Clear();

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
                    Console.Clear();
                    Console.WriteLine("Please enter number.");
                    Console.WriteLine();
                    continue;
                }

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
                        Console.WriteLine($"{currentNumber} is not option " +
                            $"please try again.");
                        Console.WriteLine();
                        break;
                }

            }
        }

        public static void TestCheckingAccount()
        {
            CheckingAccount checkingAccount = null;

            decimal initalAmount;
            decimal feeAmount;

            bool passBool = false;
            int currentNumber = 0;


            Console.Clear();

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


            Console.Clear();

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
                    Console.Clear();
                    Console.WriteLine("Please enter number.");
                    Console.WriteLine();
                    continue;
                }

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
                        Console.WriteLine($"{currentNumber} is not option " +
                            $"please try again.");
                        Console.WriteLine();
                        break;
                }

            }
        }

        public static void TestLoan()
        {
            Loan loan = null;
            decimal initalAmount;
            decimal interestRate;

            bool passBool = false;
            int currentNumber = 0;

            Console.Clear();

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


            Console.Clear();

            while (currentNumber != 5)
            {

                Console.WriteLine("What would you like to do with the " +
                    "Loan account:");
                Console.WriteLine("1: Borrow more money.");
                Console.WriteLine("2: Payback some or all the borrowed ammount.");
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
                    Console.Clear();
                    Console.WriteLine("Please enter number.");
                    Console.WriteLine();
                    continue;
                }

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
                        Console.WriteLine($"{currentNumber} is not option " +
                            $"please try again.");
                        Console.WriteLine();
                        break;
                }

            }

        }
    }
}
