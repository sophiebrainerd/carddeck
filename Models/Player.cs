using System;
using System.Collections.Generic;

namespace CardDeck.Models
{
    public class Player
    {
        public string Name;

        public List<Card> Hand = new List<Card>();

        public Deck playerDeck = new Deck();
        public Card Draw()
        {
            // from Deck.Deal():
            // Card cardToDeal = playerDeck[0];
            // playerDeck.Remove(cardToDeal);
            // return cardToDeal;
            
            Card cardToDraw = playerDeck.Deal();
            Hand.Add(cardToDraw);
            return cardToDraw;
        }

        public Card Discard(int idx)
        {
            Card cardToDiscard = Hand[idx];
            if (cardToDiscard != null){
                Hand.Remove(cardToDiscard);
                return cardToDiscard;
            }
            else {
                return null;
            }
        }
    }
}