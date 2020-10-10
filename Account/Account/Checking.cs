namespace Inheritance
{
    namespace Inheritance
    {
        using System.Collections.Generic;

        namespace Inheritance
        {

            class Checking : Account
            {
                //  If the Account has an associated Overdraft Protection account then
                //      when there are Insufficient Funds the code will attempt to make an additional withdrawal from the Overdraft account to complete the transaction
                private Account overdraftProtection;

                public Account OverdraftProtection { get => overdraftProtection; set => overdraftProtection = value; }

                public Checking(string accountName, decimal balance, float interestRate) : base(accountName, balance, interestRate)
                {
                }

                public new void Withdrawal(decimal amount)
                {
                    //  ooooh! not enough money
                    if (amount > Balance)
                    {
                        //  is there an overdraft protection account defined?
                        if (OverdraftProtection == null)
                        {
                            //  sorry can't do the withdrawal. No mun no fun
                            Transaction transaction = new Transaction(amount, "No Overdraft Protection Account assigned", false);
                            Transactions.Add(transaction);
                        }   //  We do have overdraft protection. But do we have enough money there to cover the draft AND the overdraft fee
                        else if (amount > Balance + OverdraftProtection.Balance + 15.00M)
                        {   //  Wow! times are hard. You don't have any money anywhere. You should become a programmer and you will have lots of money
                            Transaction transaction = new Transaction(amount, "Overdraft Account has Insufficient Funds", false);
                            Transactions.Add(transaction);
                        }
                        else
                        {   //  Great! We found enough money between the two accounts. 
                            decimal tempAmount = amount + 15.00M;     //  we need an additional $15 for the overdraft transfere fee!!

                            //  after we drain this account we will have tempAmount left we need from the overdraft account
                            tempAmount -= Balance;
                            Transaction transaction = new Transaction(Balance, "Account Withdrawal Succeeded", true);
                            Transactions.Add(transaction);
                            //  Account is now empty
                            Balance = 0;

                            //  take the remaining amount needed from the Overdraft account
                            OverdraftProtection.Withdrawal(tempAmount);
                        }
                    }
                    else
                    {   //  Yay! We have money we can use for the withdrawal
                        Balance -= amount;
                        Balance -= 1.00M;       //  transaction fee
                        Transaction transaction = new Transaction(amount, "Account Withdrawal Succeeded", true);
                        Transactions.Add(transaction);
                        transaction = new Transaction(1, "Withdrawal fee", true);
                        Transactions.Add(transaction);
                    }
                }
            }
        }
    }
}