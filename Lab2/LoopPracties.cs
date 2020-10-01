using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class LoopPracties
    {
      static void Main(string[] args)
        {
            Console.WriteLine(byte.MinValue);
            var x = 9;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");

                }

                Console.WriteLine("");
            }

            int num = Utils.GetNumber("Sum of numbers up to: ");
            int total = 0;
            for (int i = 0; i <= num; i++)
            {
                total += i;
            }
            Console.WriteLine($"Total of numbers less than {num} is {total}");
            //4	Read 10 numbers from keyboard and find their sum and average
            total = 0;
            for (int i = 0; i < 10; i++)
            {
                num = Utils.GetNumber("Enter # ");
                total += num;
            }
            //1	Display the first 10 numbers
           num = Utils.GetNumber("Enter loop max: ");
            for (int i = 0; i < num; i++)
         {
             Console.WriteLine($"next number {i}");
            }
            //2	Read a number and find the sum of numbers from 0 to that number.Number = 5? 5+4+3+2+1 answer would be 15
        num = Utils.GetNumber("Sum of numbers up to: ");
             total = 0;

            for (int i = 0; i <= num; i++)
            {
                total += i;
            }

            //// //9	Display the pattern like right angle triangle using an asterisk

            int rows = Utils.GetNumber("How tall is your tree: ");
            int starCnt = 1;
            for (int i = 1; i <= rows; i++)
            {
                Console.WriteLine(i + " " + (rows - i) + " " + starCnt);
                starCnt += 2;
            }
            //4	Read 10 numbers from keyboard and find their sum and average
            total = 0;
            for (int i = 0; i < 10; i++)
            {
                num = Utils.GetNumber("Enter # ");
                total += num;
            }
           // int num = Utils.GetNumber("Sum of numbers up to: ");
           // int total = 0;
            for (int i = 0; i <= num; i++)
            {
                total += i;
            }
            Console.WriteLine($"Total of numbers less than {num} is {total}");
            //4	Read 10 numbers from keyboard and find their sum and average
            total = 0;
            for (int i = 0; i < 10; i++)
            {
                num = Utils.GetNumber("Enter # ");
                total += num;
            }
            //1	Display the first 10 numbers
            //int num = Utils.GetNumber("Enter loop max: ");
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine($"next number {i}");
            //}
            //2	Read a number and find the sum of numbers from 0 to that number.Number = 5? 5+4+3+2+1 answer would be 15
            //int num = Utils.GetNumber("Sum of numbers up to: ");
            //int total = 0;

            for (int i = 0; i <= num; i++)
            {
                total += i;
            }
        }


    }
}