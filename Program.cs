using System;
using CardDeck.Models;

namespace CardDeck
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            d1.Shuffle();
            Player Sophie = new Player();
            Sophie.Draw();
        }
    }
}
