using System;

namespace Assignment_5
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message): base(message)
        {
        }
    }

    class BankAccount
    {
        private int balance;

        public BankAccount(int amount)
        {
            balance = amount;
        }

        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount Deposited: " + amount);
        }

        public void Withdraw(int amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Not enough balance");
            }

            balance = balance - amount;
            Console.WriteLine("Amount Withdrawn: " + amount);
        }

        public void ShowBalance()
        {
            Console.WriteLine("Current Balance: " + balance);
        }
    }

    internal class ExceptionEg
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount acc = new BankAccount(5000);

                acc.ShowBalance();

                acc.Deposit(2000);
                acc.ShowBalance();

                acc.Withdraw(8000);   
                acc.ShowBalance();
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Transaction Completed.");
            }

            Console.ReadLine();
        }
    }
}