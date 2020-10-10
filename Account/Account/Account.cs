
        using System;
        using System.Collections.Generic;
        using System.Text;
         using System.Transactions;

namespace Inheritance
        {

            class Account
            {
                //  Properties of our Account class
                private string accountName;
                private decimal balance;
                private List<Transaction> transactions;
                private float interestRate;

                //      Getters and Setters
                public string AccountName { get => accountName; set => accountName = value; }
                public decimal Balance { get => balance; set => balance = value; }
                public float InterestRate { get => interestRate; set => interestRate = value; }
                public List<Transaction> Transactions { get => transactions; set => transactions = value; }

                //      Constructor             Account checking = new Account("Checking", 100.0f, 0.02f);
                public Account(string accountName, decimal balance, float interestRate)
                {
                    this.accountName = accountName;
                    this.balance = balance;
                    this.interestRate = interestRate;
                    transactions = new List<Transaction>();
                    Transaction newAccount = new Transaction(balance, "New Account Opened: " + accountName, true);
                    transactions.Add(newAccount);
                }

                //  Deposit we can add money to the account
                public decimal Deposit(decimal amount)
                {
                    Balance += amount;
                    Transaction deposit = new Transaction(amount, "Deposit", true);
                    transactions.Add(deposit);
                    return Balance;
                }

                //      Withdrawal we can take money from the account
                public decimal Withdrawal(decimal amount)
                {
                    if (Balance - amount < 5.00M)
                    {
                        Transaction oops = new Transaction(amount, "Could not process. Balance too low", false);
                        transactions.Add(oops);
                        return Balance;
                    }
                    Balance -= amount;
                    Transaction withDrawal = new Transaction(amount, "WithDrawal", true);
                    transactions.Add(withDrawal);
                    return Balance;
                }

                //  ShowTransactions - list to the console the transactions performed since day 1 
                public void ShowTransactions()
                {
                    foreach (Transaction trans in transactions)
                    {
                        Console.WriteLine(trans);
                    }
                }

                public override string ToString()
                {
                    return accountName + " : Balance = " + balance;
                }
            }
        }
