using System;

namespace Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter number1");
            int num1 = Console.Read();
            num1 = Convert.ToInt32(Console.Read());
            Console.WriteLine("Enter number2");
            int num2 = Convert.ToInt32(Console.Read());
            sum = num1 + num2;
            Console.WriteLine("{0} = {1} plus {2}", sum, num1, num2);

        }
    }
}
