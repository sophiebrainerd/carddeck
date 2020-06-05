using System;
using System.Collections.Generic;

namespace CardDeck.Models 
{
    public class Deck
    {
        public static Random rand = new Random();        
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
                newDeck.Add(new Card(stringval, suit));
                }
            }
        }

        public Card Deal()
        {
            Card cardToDeal = newDeck[0];
            newDeck.Remove(cardToDeal);
            return cardToDeal;
        }

        public void Reset()
        {
            newDeck = new List<Card>();
            string[] suits = new string[]{"Spades", "Hearts", "Diamonds", "Clubs"};
            string[] stringvals = new string[]{"Ace", "Deuce", "Tre", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            int[] vals = new int[]{2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach(string suit in suits)
            {
                foreach(string stringval in stringvals)
                {
                newDeck.Add(new Card(stringval, suit));
                }
            }
        }

        public void Shuffle()
        {
            for (int i=0; i<newDeck.Count; i++){
                Card temp = newDeck[i];
                int randIdx = rand.Next(newDeck.Count);
                newDeck[i] = newDeck[randIdx];
                newDeck[randIdx] = temp;
            }
        }
    }
}