using System;
using System.Collections.Generic;

namespace CardDeck.Models 
{
    public class Deck
    {
        public List<Card> newDeck = new List<Card>();

        public Deck()
        {
            string[] suits = new string[]{"Spades", "Hearts", "Diamonds", "Clubs"};
            string[] stringvals = new string[]{"Ace", "Deuce", "Tre", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            int[] vals = new int[]{2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach(string suit in suits)
            {
                foreach(string stringval in stringvals)
                {
                newDeck.Add(new Card(stringval, suit, val));
                }
            }
        }
    }
}