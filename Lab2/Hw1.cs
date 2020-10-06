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
            int num1 , num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("{0}={1} plus {2}",sum,num1,num2);


        }
    }
}
