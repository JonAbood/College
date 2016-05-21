using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Author : Jonathan Abood
Purpose : create the card
Errors : when printing the user's cards, duplicates are possible
Other : 
*/
namespace CardDeckHWJonathanAbood
{
    class Card
    {
        int value;// value of card
        string suit;// suit of card
        /*
        card constructor with 2 parameters, 1 as an int value, the other as a string suit
        */
        public Card(int p_value, string p_suit)
        {
            value = p_value;
            suit = p_suit; 
        }
        
        /* 
        this method sets the card values = to a suit
        */
        public override string ToString()
        {
            string cards = " ";// card is originially blank
            switch(value)
            {
                case 1:
                    cards = ": Ace of " + suit;
                    break;
                case 11:
                    cards = ": Jack of " + suit;
                    break;
                case 12:
                    cards = ": Queen of " + suit;
                    break;
                case 13:
                    cards = ": King of " + suit;
                    break;
                default:
                    cards = ": " + value + " of " + suit;// any value not = to 1,11,12,13
                    break;

            }
            return cards;// returns cards

        }
    }
}
