
using Pattren;
using System;

namespace Pattren
{
    class ForPractice

    {
        static void Main(string[] args)
        {
            for (int i = 0; i <5; i++)
            {
                Console.Write(i + "  ");
                for (int j = 0; j <i; j++)
                {
                    Console.Write(j);

                    
                }
                Console.WriteLine("");
            }

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
            for (int i = 0; i< 10; i++)
            {
                num = Utils.GetNumber("Enter # ");
                total += num;
            }
//1	Display the first 10 numbers
int num = Utils.GetNumber("Enter loop max: ");
//for (int i = 0; i < num; i++)
//{
//    Console.WriteLine($"next number {i}");
//}
//2	Read a number and find the sum of numbers from 0 to that number.Number = 5? 5+4+3+2+1 answer would be 15
 num = Utils.GetNumber("Sum of numbers up to: ");
int total = 0;
     
            for (int i = 0; i <= num; i++)
            {
                total += i;
            }
    }
}
