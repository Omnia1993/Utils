using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Hw1
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter number1");
            int num1;
           
            num1 = Convert.ToInt32(Console.Read());
            Console.WriteLine("Enter number2");
            int num2 = Convert.ToInt32(Console.Read());
            sum = num1 + num2;

            Console.WriteLine("sumation"+sum);


        }
    }
}
