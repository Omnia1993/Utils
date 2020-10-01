using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab2
{
    class Utils
    {

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        public static float GetFloat(string prompt)
        {
            float num;
            Console.Write(prompt);
            do
            {
                if (float.TryParse(Console.ReadLine(), out num))
                {
                    break;
                }
                else
                   {
                   
                    Console.WriteLine("Bad input. Try again");
                }
            } while (true);
            return num;
        }
        public static int GetNumber(string prompt)
        {
            int num;
            Console.Write(prompt);
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input. Try again");
                }
            } while (true);
            return num;
        }
       public static int GetNumber(string prompt, int max)
        {
            int num;
            do
            {
                num = GetNumber(prompt);
                if (num > max)
                {
                    Console.WriteLine("Number too large");
                }
            } while (num > max);
            return num;
        }
       
    }


}

