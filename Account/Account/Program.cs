namespace Inheritance
{
    namespace Inheritance
    {
        using System;

        namespace Inheritance
        {
            using System;
            using System.Collections.Generic;
            using System.Text;

            namespace Inheritance
            {

                class Program
                {
                    static void Main(string[] args)
                    {
                        int balance;
                        string accountName;
                        int menuOption = 0;
                        Checking checking = null;
                        Savings savings = null;

                        while (menuOption != 1)
                        {
                            menuOption = GetNumber("1 - Exit\n" +
                                                   "2 - Create Checking\t3 - Create Savings" +
                                                   "4 - something else \t5 - another option");
                            switch (menuOption)
                            {
                                //  exit the ATM
                                case 1:
                                    break;

                                case 2:
                                    accountName = GetInput("Account Name");
                                    balance = GetNumber("Initial Amt: ");
                                    checking = new Checking(accountName, balance, 0.02f);
                                    break;

                                case 3:
                                    accountName = GetInput("Account Name");
                                    balance = GetNumber("Initial Amt: ");
                                    savings = new Savings(accountName, balance, 0.02f);
                                    break;

                                default:
                                    break;
                            }
                        }
                    }   // end of the Main method. Everything comes after here

                    public static string GetInput(string prompt)
                    {
                        Console.Write(prompt);
                        string str = Console.ReadLine();
                        return str;
                    }   // end of the GetInput method

                    public static int GetNumber(string prompt)
                    {
                        int userNumber;
                        string strNumber = GetInput(prompt);
                        while (!Int32.TryParse(strNumber, out userNumber))
                        {
                            Console.WriteLine("That is not an integer");
                            strNumber = GetInput(prompt);
                        }
                        return userNumber;
                    }   // end of the GetNumber method
                }
            }
        }
    }
}