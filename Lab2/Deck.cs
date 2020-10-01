using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Deck
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;//to print any Charctor 
           
            Card aceOfHeart = new Card("A", "♥",14);
            Console.WriteLine(aceOfHeart);
            string[] ranks = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K", "A" };
            string[] suits = { "♥", "♦", "♣", "♠" };

            List<Card> deck = new List<Card>();
            for (int r = 0; r < ranks.Length; r++)
            {
                for (int s = 0; s < suits.Length; s++)
                {
                    Card card = new Card(ranks[r], suits[s], r + 1);
                    deck.Add(card);
                }
            }
            Console.WriteLine();
        }
    }
}
