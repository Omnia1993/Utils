using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Lab2
{
    public class Person
    {
        public int age;

    }
    public enum ShippingMethod
    {
        RegularAirMail = 1, RegisterdAirMail = 2,
        Express = 3
    }
    class Mosh
    {

        static void Main(string[] args)
        {




            bool isGoldCustomer = true;
            bool isGoldCustomers= true;
           float price;
            if(isGoldCustomer)
                {
               price = 12.45f;

            }
            else
            {
                price = 50.9f;

            }











            var method = ShippingMethod.Express;
            var id = 2;
            var strin = "Express";

            // Console.WriteLine((ShippingMethod)id);
            //Console.WriteLine(method.ToString()) ;
            var firstName = "mosh";
            string last = "mmm";
            string mid = "werweer";

            var b = string.Format("my name is {0} {1} {2}", firstName, mid, last);
            // Console.WriteLine(b);
            var array = new string[3] { "mno", "gg", "hh" };
            var str = string.Join(",", array);
            var text = "hi mno\nLook at this paths \nc:folder1\\folder2\\folder3\\folder4";
            // Console.WriteLine(text);
            int num = 1;
            test(num);
            Console.WriteLine(num);
            var person = new Person() { age = 20 };
            testAgain(person);
            Console.WriteLine(person.age);

        }
        public static void test(int x)
        {

            x += 10;


        }
        public static void testAgain(Person person)
        {
            person.age += 10;
        }
    }







}

