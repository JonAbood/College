using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_AboodJonathan
{
    /*
    Author : Jonathan Abood
    Purpose : Run the logic of the program
    known errors : entering nothing crashes the program
    */
    class Program
    {
        static void Main(string[] args)
        {
            SongManager mySongManager = new SongManager();//create new song manager
            BandManager myBandManager = new BandManager();// create new band manager
            int userInput = -1;//used to allow the do while loop to run its first iteration
            do
            {
                //----Prints stuff---\\
                Console.WriteLine("1. Print a song's writer/composer.");
                Console.WriteLine("2. Print a song's cover band or recording artist.");
                Console.WriteLine("3. Print all details about a song.");
                Console.WriteLine("4. Print details about every song in the database.");
                Console.WriteLine("5. Print a band's genre/type.");
                Console.WriteLine("6. Print all details about a band.");
                Console.WriteLine("7. Print details about every band in the database.");
                Console.Write("8. Quit. ");
      
                string userString = Console.ReadLine();//saves user's input
                bool Parse = int.TryParse(userString, out userInput);//parses the user's input from a string into an interger

                Console.WriteLine();//space to look nice

                //---If the suerInput matches, then do it---\\
                if (userInput == 1)
                {
                    mySongManager.PrintSongWriter();
                }
                else if (userInput == 2)
                {
                    mySongManager.PrintBand();
                }
                else if (userInput == 3)
                {
                    mySongManager.PrintOne();
                }
                else if (userInput == 4)
                {
                    mySongManager.PrintAll();
                }
                else if (userInput == 5)
                {
                    myBandManager.PrintBandType();
                }
                else if (userInput == 6)
                {
                    myBandManager.PrintOneBand();
                }
                else if (userInput == 7)
                {
                    myBandManager.PrintAllBands();
                }
            }while(userInput != 8);//runs until the user enters 8, at which point the program will end
            
            
        }
        
    }
}
