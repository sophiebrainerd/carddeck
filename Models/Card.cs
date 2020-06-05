using System;
using System.Collections.Generic;

namespace CardDeck.Models
{
    public class Card
    {
        public string StringVal;
        public string Suit;

        public Card(string stringVal, string suit){
            StringVal = stringVal;
            Suit = suit;
        }

        public void Display()
        {
            Console.WriteLine($"The {StringVal} of {Suit}");
        }
    }
}