using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Author : Jonathan Abood
Purpose : print the number of cards the users requests
Errors : when printing the user's cards, duplicates are possible
Other : can enter anything and won't crash
*/
namespace CardDeckHWJonathanAbood
{
    class Program
    {
        static void Main(string[] args)
        {
            int cardsDealt = -1;// this will allow the program to run if the user enters nothing
            
            do// do while loop, used to make this run at least once
            {
                Console.WriteLine("Enter a number between 1-52.");// aks the user to enter an input between the range
                string answer = Console.ReadLine();// saves the user's input
                Boolean parsed = int.TryParse(answer, out cardsDealt);// try parses, so any invald inputs don't crash the program 
            }
            while (cardsDealt < 1 || cardsDealt > 52);// the while of the do while loop 

            Deck cardDeck = new Deck();// declares a new Deck() called cardDeck

            string cards = cardDeck.Deal(cardsDealt);// cardDeck calls deal with cardsDealt as the parameter

            Console.WriteLine("Cards dealt:\n" + cards);// prints the number of the cards the user requested
            cardDeck.Print();// prinbts out the full deck
        }
    }
}
