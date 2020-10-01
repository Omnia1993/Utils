using System;
using System.Collections.Generic;
using System.Text;

namespace Mosh
{
    class Car
    {
        static void Main(string[] args)

        {
            var speedLimit = 120;
            int demeritPoint = 02;
            Console.WriteLine("Enter speed");
            double speed = Convert.ToDouble(Console.ReadLine());



            if (speed < speedLimit)
            {
                Console.WriteLine("ok");
            }
            else if (speed > speedLimit)
            { 
                    demeritPoint = +1;
                if(speed==speedLimit+5)
                Console.WriteLine(speed);
                }
                if (demeritPoint > 12)
                {
                    Console.WriteLine("licened suspended");
                }


            }
        }
    }





