using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Author : Jonathan Abood
Purpose : create the deck
Errors : when printing the user's cards, duplicates are possible
Other : 
*/
namespace CardDeckHWJonathanAbood
{
    class Deck
    {
        const int DECK_SIZE = 52;// size of deck
        private Random randomCard = new Random();// random used for pick random cards when the user asks for cards
        private Card[] deck = new Card[DECK_SIZE];// sets the deck array = to the size of the deck

        public Deck()//constuctor with no 
        {
            int pos = 0;//position in the array
            for (int q = 1; q <= 13; q++)// represents the 13 possible card values the card can be
            {
                deck[pos] = new Card(q, "hearts\n");// place a new card object in the deck array
                pos++;// increases the position of the array by one so it continues to fill all the spots
            }
            for (int q = 1; q <= 13; q++)// same as above
            {
                deck[pos] = new Card(q, "clubs\n");
                pos++;
            }
            for (int q = 1; q <= 13; q++)// same as above
            {
                deck[pos] = new Card(q, "diamonds\n");
                pos++;
            }
            for (int q = 1; q <= 13; q++)// same as above
            {
                deck[pos] = new Card(q, "spades\n");
                pos++;
            }
        }
        /*  
        deals the number of cards the user requested with random values.
        */
        public string Deal(int cardsDealt)
        {
            string cardDrawn = "";// sets cardDrawn to nothing

            for(int q = 0; q < cardsDealt; q++)// goes until the amount of cards is the user asked for is dealt
            {
                int number = randomCard.Next(DECK_SIZE);// picks random number from the deck array
                cardDrawn = cardDrawn + " " + deck[number];// prints the card drawn
            }
            return cardDrawn;// returns the card drawn
        }
        /*
        prints the full deck
        */
        public void Print()
        {
            Console.WriteLine("Full deck.");// writes full deck
            for (int q = 0; q < DECK_SIZE; q++)// goes through and prints every position in the array
            {
                Console.Write(deck[q]);// prints what position of the array you are in 
            }
        }
        
    }
}
