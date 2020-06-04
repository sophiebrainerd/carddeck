using System;
using System.Collections.Generic;

namespace CardDeck.Models
{
    public class Card
    {
        public string StringVal;
        public string Suit;
        public int Val {
            get
            {
                return Val;
            }
            set
            {
                if (Stringval == "Deuce"){
                    Val = 2;
                }
                else if (Card.Stringval == "Tre"){
                    Val = 3;
                }
                else if (Stringval == "Four"){
                    Val = 4;
                }
                else if (Stringval == "Five"){
                    Val = 5;
                }
                else if (Stringval == "Six"){
                    Val = 6;
                }
                else if (stringval == "Seven"){
                    Val = 7;
                }
                else if (stringval == "Eight"){
                    Val = 8;
                }
                else if (stringval == "Nine"){
                    Val = 9;
                }
                else {
                    Val = 10;
                }                
            }
        }

        public Card(string stringVal, string suit){
            StringVal = stringVal;
            Suit = suit;
            // Val = val;
        }

        public void Display()
        {
            Console.WriteLine($"The {StringVal} of {Suit}");
        }
    }
}