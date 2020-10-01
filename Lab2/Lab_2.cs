using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Lab2
{


    class Lab_2
    {
        static void Main(string[] args)
        {
            /*
Project:    Lab 2 Calculate Batting Average
Date:        09/15/2020
Author:   Omnia
Notes:      This program reads in a baseball player's name,
           number of hits and number of at bats.
           The player's batting average is calc ulated and displayed
*/



            // Variable declaration
            string strPlayerName;
            double dbHits, dbAtBats; // later we will see the need to change this to dboule dblHits, dblAtBats
            double dblBattingAverage;

            Console.WriteLine("This program calculates a baseball player's batter average");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter player's name: ");
            //  or we could use the Utils class strPlayerName = Utils.GetInput("Enter player's name");
            strPlayerName = Console.ReadLine();

            //  prompt for hits and at bats
            Console.Write("Enter the player's # of hits: ");
            dbHits = Convert.ToInt32(Console.ReadLine());// or we could use the Utils class hHits = Utils.GetNumber("Enter the player's # of at bats: ");
            Console.Write("Enter the player's # of at bats: ");
            //  or we could use the Utils class hHits = Utils.GetNumber("Enter the player's # of hits: ");      

            dbAtBats = Convert.ToInt32(Console.ReadLine());
            // calculation
            dblBattingAverage = dbHits / dbAtBats;
            Console.WriteLine($"{strPlayerName}'s batting averate is {dblBattingAverage}");
            //4	Read 10 numbers from keyboard and find their sum and average
            /*int a, b, c, d, e, f, g, h, i, j;
            Console.WriteLine( "enter number");
            a = Convert.ToInt32(Console.ReadLine());
           b= Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            f = Convert.ToInt32(Console.ReadLine());
            g = Convert.ToInt32(Console.ReadLine());
            h = Convert.ToInt32(Console.ReadLine());
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
           Console.WriteLine(sum);*/
            int num;
            for (int i = 0; i < 5; i++)
            {
                num = Utils.GetNumber("enter num");





            }





        }
    }



}

