using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1JonathanAbood
{
    class Program
    {
        /* Jonathan Abood 2/10/16
        Description ::::: This is a text based story adventure
        The user is told to enter a 1 or a 2 for which option they wish to explore.
        If they enter an incorrect answer that is an NUMBER then it will simply ask the user to try again, by entering a 1 or 2
        If they enter a STRING the program will crash
        */
        static void Main(string[] args)
        {
            int userChoice;//declares userCjoice, which we will use later

            Console.WriteLine("--------------");// makes a break in the top
            Console.WriteLine("Enter a 1 for a story involving a priate or a 2 for a story invloving a bear");//choice one
            userChoice = GetUserChoice(Console.ReadLine());// gets the user's choice, calls GetuserChoice and sends the user's choice to the GetUserChoice, to parse it into an int
            if (userChoice == 1)// if the user pressed 1
            {
                Console.WriteLine("Alright lets get started.");
                Console.WriteLine("You run into a pirate, press 1 to kill the pirate or 2 to befriend the pirate.");
                userChoice = GetUserChoice(Console.ReadLine());// gets the user's choice, calls GetuserChoice and sends the user's choice to the GetUserChoice, to parse it into an int
                switch (userChoice)//puts the user's choice into a switch/case
                {
                    case 1://if the choice was a 1
                        Console.WriteLine("You killed the pirate, good job.");
                        Console.WriteLine("You find the pirates map, 1 to go after his treasure, 2 to sell the map.");
                        userChoice = GetUserChoice(Console.ReadLine());// gets the user's choice, calls GetuserChoice and sends the user's choice to the GetUserChoice, to parse it into an int
                        switch (userChoice)//puts the user's choice into a switch/case
                        {
                            case 1://if the choice was a 1
                                Console.WriteLine("You went after his treasure and died");
                                Console.WriteLine("The end!");
                                break;//breaks out of the case

                            case 2://if the choice was a 2
                                Console.WriteLine("You sold his map and made 200 gold!");
                                Console.WriteLine("The end!");
                                break;//breaks out of the case
                        }
                    break;//breaks out of the case
                    case 2://if the choice was a 2
                        Console.WriteLine("You befriended the pirate.");
                        Console.WriteLine("The pirates wants to go partying, 1 to go partying, 2 to refuse.");
                        userChoice = GetUserChoice(Console.ReadLine());// gets the user's choice, calls GetuserChoice and sends the user's choice to the GetUserChoice, to parse it into an int
                        switch (userChoice)//puts the user's choice into a switch/case
                        {
                            case 1://if the choice was a 1
                                Console.WriteLine("You decided to party with the pirate and the party was lit!!!!");
                                Console.WriteLine("the end!");
                                break;//breaks out of the case
                            case 2://if the choice was a 2
                                Console.WriteLine("You refused to party with the pirate, so he cut your head off.");
                                Console.WriteLine("The end!");
                                break;//breaks out of the case
                        }   
                    break;//breaks out of the case
                }

            }
            
            else if(userChoice == 2)// if the user picked 2
            {
                Console.WriteLine("Alright lets get started.");
                Console.WriteLine("So you are walking down the road, when a bear runs in front of you, 1 to attack, 2 to hug.");
                userChoice = GetUserChoice(Console.ReadLine());// gets the user's choice, calls GetuserChoice and sends the user's choice to the GetUserChoice, to parse it into an int
                switch (userChoice)//puts the user's choice into a switch/case
                {
                    case 1://if the choice was a 1
                        Console.WriteLine("You killed the bear and went on your way.");
                        Console.WriteLine("Now, all of a sudden, you are getting mugged, 1 to fight back or 2 to run.");
                        userChoice = GetUserChoice(Console.ReadLine());// gets the user's choice, calls GetuserChoice and sends the user's choice to the GetUserChoice, to parse it into an int
                        switch (userChoice)//puts the user's choice into a switch/case
                        {
                            case 1://if the choice was a 1
                                Console.WriteLine("You attempt to fight off the mugger and die.");
                                Console.WriteLine("The end.");
                                break;//breaks out of the case
                            case 2://if the choice was a 2
                                Console.WriteLine("You ran away, but lost 100 dollars that was in your wallet.");
                                Console.WriteLine("The end.");
                                break;//breaks out of the case
                        }
                    break;//breaks out of the case
                    case 2://if the choice was a 2
                        Console.WriteLine("You hug the bear and make him feel better and continue on your way.");
                        Console.WriteLine("Now, all of a sudden, you are getting mugged, 1 to fight back or 2 to run.");
                        userChoice = GetUserChoice(Console.ReadLine());// gets the user's choice, calls GetuserChoice and sends the user's choice to the GetUserChoice, to parse it into an int
                        switch (userChoice)//puts the user's choice into a switch/case
                        {
                            case 1://if the choice was a 1
                                Console.WriteLine("As you fight back, the bear comes and saves your life!");
                                Console.WriteLine("You get on the bears back and ride him into the sunset.");
                                Console.WriteLine("The end.");
                                break;//breaks out of the case
                            case 2://if the choice was a 2
                                Console.WriteLine("As you run away, the bear attacks the mugger, and then returns your wallet with all your money.");
                                Console.WriteLine("You get on the bears back and ride him into the sunset.");
                                Console.WriteLine("The end.");
                                break;//breaks out of the case
                        }
                    break;//breaks out of the case
                }

            }
            
        }
        static int GetUserChoice(string userChoice)// takes the users input in
        {
            int numberChoice = Convert.ToInt32(userChoice); // parses the user's answer from a string to an int
            int errorChoice = 0;// used later, when the user enters and incorrect number

            if (numberChoice == 1)//if they enter a 1
            {
                return numberChoice;// return a 1
            }
            else if (numberChoice == 2)//if they enter a 2
            {
                return numberChoice;// return a 2
            }
            else
            {
                while (errorChoice != 1 || errorChoice !=2)// if they dont enter a 1 or a 2 do this
                {
                    Console.WriteLine("Please enter a 1 or 2.");
                    errorChoice = Convert.ToInt32(Console.ReadLine());// coverts their asnwer from a string to an int
                    if(errorChoice == 1)// if they entered a 1
                    {
                        return numberChoice = 1;// return a 1
                        
                    }
                    else if(errorChoice == 2)// if they entered a 2
                    {
                        return numberChoice = 2;//return a 2
                    }
                    
                }
                return numberChoice;//return their choice, this is only here so the GetUserChoice doesnt break, wihtout this return here it wont work properly
            }
           
        }
    }
}
