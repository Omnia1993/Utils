using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab2
{
    class LinqExamples
    {
        static void Main(string[] args)
        {
            //  let's play with arrays of numbers using the LINQ statements
            double total = 0, average;
            double biggest;
            double[] numbers = { 12, 3, 2, 43, 6, 2, 2242, 5, 3312, 3, 62, 2, 5, 4 };
            foreach (var nextNum in numbers)
            {
                total += nextNum;

            }
            average = total / numbers.Length;
            Console.WriteLine($"the total of the array is {total} and the evarege is {average}");
            //
            average = numbers.Average();
            total = numbers.Sum();




            Console.WriteLine($"21st century the  total of the array is {total} and the evarege is {average}");
            //All, Any, Average, Contains, Count, Distinct, ElementAt, Empty, First, Last, 
            //Max, Min, OrderBy(Descending), Reverse, Skip, Sum, Take, TakeLast, Where

            bool allPositive = numbers.All(nextNum => nextNum > 0);
            bool anyPositive = numbers.Any(nextNum => nextNum > 0);

            bool contains5 = numbers.Contains(5);
            var unique = numbers.Distinct();
            var firstName = numbers.First();
            var lastName = numbers.Last();

            int[] randomNums = { 43, 6, 31, 84, -21, -8, 5, 6, -21, 64, 6, 43, -8, -100, -8, 874, 42 };
            average = randomNums.Average();
            Console.WriteLine(average);
            var m = randomNums.Max();
            Console.WriteLine(m);
            var min = randomNums.Min();
            Console.WriteLine(min);
            var x = randomNums.Distinct().Count();
            Console.WriteLine(x);

            var take = randomNums.Take(3);
            Console.WriteLine();
            bool anyNeg = randomNums.Any(n => n < 0);
            Console.WriteLine(anyNeg);

            //  ask for a number Utils.GetNumber......
            //  use All to find out if all numbers in randomNums are greater than that number
            var num = Utils.GetNumber("Enter number");
            bool result = randomNums.All(my => my > num);
            Console.WriteLine(result);
            int small = Utils.GetNumber("Find numbers bigger than: ");
            var bigs = randomNums.Where(n => n > small);
            foreach (var n in bigs)
            {
                Console.WriteLine($"{n} is bigger than {small}");
            }
            int[] scores = { 21, 32, 7, 4, -2, 6, 3, -46, 6, 54, -87, 57, 89, 57, -6, 3, 43, 6, 7, -45, 5, 24, 6 };
            //  Count the scores
            //  What is the Average and Max scores
            //  How many Distinct scores are there
            //  add up the Distinct scores


            //  add up all numbers greater than 44
            var cnt = scores.Count();
            Console.WriteLine($"count of the score{cnt}");
            var avg = scores.Average();
            Console.WriteLine($"the average is {avg}");
            var discCnt = scores.Distinct().Count();
            Console.WriteLine($"The Disc count is {discCnt}");
            var disTotal = scores.Distinct().Sum();
            Console.WriteLine(discCnt);
            var numGreaterThan44 = scores.Where(n => n > 44);
            int totalqreaterThan44 = scores.Where(n => n > 44).Sum();
            //  what is the average of numbers less than 0
            Double aver = scores.Where(n => n < 0).Sum();
            //  how many numbers are between -20 and 30
            int cntBetween20and30 = scores.Where(n => n >= -20 && n < 30).Count();

            string[] animals = { "moose", "ferret", "gnu", "ant", "cow", "emu", "deer", "hippo", "bear", "jackalop", "lama" };



            //  what is the longest name


            //  how many animals are longer than 4
            var cntAnimals = animals.Where(n => animals.Length > 4).Count();
            Console.WriteLine($"the animals is {cntAnimals}");
            //  find animals that end with 'u'. use your method to print them
            var endWithU = animals.Where(n => n.EndsWith("u"));
            Console.WriteLine($"animals end with U{endWithU}");
            printList(endWithU);
            //  order the animals alphabetically and print
            var alphaOrder = animals.OrderBy(n => n);
            Console.WriteLine($" alphabetic order{alphaOrder}");
            //  what is the longest name
            string longest = animals.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
            animals.OrderByDescending(s => s.Length).First();
            Console.WriteLine($"The longest name is{longest}",3);
        }
        //  create a method to display a list
        private static void printList(IEnumerable<object> list)
        {


            {
                foreach (var x in list)
                {
                    Console.WriteLine(x);
                   

                }
               

            }
          

        }
    }
}
