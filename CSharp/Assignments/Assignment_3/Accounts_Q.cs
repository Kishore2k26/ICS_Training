using System;

namespace Assignment_3
{
    class Accounts
    {
        int accNo;
        string custName;
        string accType;
        double balance;

        public Accounts(int accNo, string custName, string accType, double balance)
        {
            this.accNo = accNo;
            this.custName = custName;
            this.accType = accType;
            this.balance = balance;
        }

        public void Credit(double amount)
        {
            balance += amount;
        }

        public void Debit(double amount)
        {
            balance -= amount;
        }

        public void UpdateBalance(char transType, double amount)
        {
            if (transType == 'D')
                Credit(amount);
            else if (transType == 'W')
                Debit(amount);
        }

        public void ShowData()
        {
            Console.WriteLine(accNo);
            Console.WriteLine(custName);
            Console.WriteLine(accType);
            Console.WriteLine(balance);
        }
    }

    internal class Accounts_Q
    {
        static void Main(string[] args)
        {
            Accounts a = new Accounts(101, "Kishore", "Savings", 5000);
            a.UpdateBalance('D', 2000);
            a.UpdateBalance('W', 4000);
            a.ShowData();
        }
    }
}