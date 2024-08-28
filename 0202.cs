/*
2.	Develop a console program that models a simple bank account. Create a class named ‘BankAccount’ with properties 
AccountNumber and Balance. Implement a method ‘Deposit’ that allows the user to deposit money into the account. 
Instantiate an object, perform a deposit, and display the updated balance.
*/
using System;


namespace Tutorial
{
    class BankAccount
    {

        private string AccountNumber;
        public int balance { get; set; }

        public string accountN
        {
            get { return AccountNumber; }
            set { AccountNumber = value; }
        }

        public void DepositMethod(int amount)
        {
            if (amount >= 0)
            {
                balance = balance + amount;
                Console.WriteLine($"You input{amount} and new balance is {balance}");
            }
            else
            {
                Console.WriteLine("Deposit can not be negative value");
            }
        }



    }

    class program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();
            account.balance = 1000;
            account.DepositMethod(100);
            account.accountN = "1234567";

            Console.WriteLine($"Account number: {account.accountN} \nAccount balance: {account.balance}");

            Console.ReadKey();
        }
    }
}