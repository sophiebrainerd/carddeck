using System;
using CardDeck.Models;

namespace CardDeck
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Deck poker = new Deck();
            foreach(Card c in poker.newDeck)
            {
                c.Display();
            }
        }
    }
}
