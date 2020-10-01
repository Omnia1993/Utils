using System;

namespace Lab2
{
    class Lab6_ParallelArray
    {
        static void Main(string[] args)
        {


            string[] names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            string[] phone = { "817-555,1334", "817-555-3882", "972-555-8211", "469-555-1617", "817-555-2803" };
            string search;

            search = Utils.GetInput("Type a name to search for in the phone book: ");
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].IndexOf(search) >= 0)
                {
                    Console.WriteLine($"{names[i]} = {phone[i]}");
                }
            }

        }
    }
}
