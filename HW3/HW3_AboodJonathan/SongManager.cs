using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_AboodJonathan
{
    /*
    Author : Jonathan Abood
    Purpose : Creates an array of Song objects to interact with
    known errors : 
    */
    class SongManager
    {
        Song[] songArray;//declares an array of Songs

        //---Main---\\
        public SongManager()
        {
            songArray = new Song[3];//array length hard codes to 2
            songArray[0] = new Song("Ballin", "Logic", "logic");//array place set
            songArray[1] = new Song("Snow", "Red Hot Chili Peppers", "Anthony Kiedis");//array place set
            songArray[2] = new Song("Indestructable", "Disturbed", "David Drainman");//array place set
        }

        //---PrintAll---\\
        public void PrintAll()
        {
            for(int q = 0; q < songArray.Length; q++)//runs the length of the array
            {
                songArray[q].Print();//Calls the song print method
            }
        }

        //---PrintOne---\\
        public void PrintOne()
        {
            Console.Write("Please enter a song name. ");
            string userString = Console.ReadLine().ToLower();//sets the user's response to all lower case

            bool inArray = false;//used to work error message

            for (int q = 0; q < songArray.Length; q++)//runs the length of the array
            {
                if (songArray[q].SongName.ToLower() == userString)//if their answer is in the array
                {
                    inArray = true;//set to true to not trigger the next if statement 
                    songArray[q].Print();//calls the print method for whatever place in the array the user's response is
                }
            }
            if (!inArray)//if their answer is not in the array
            {
                Console.WriteLine("The song "+userString+ " is not there.\n");//prints when user's response isn't in the array
            }
        }

        //---PrintSongWriter---\\
        public void PrintSongWriter()
        {
            Console.Write("Please enter a song name. ");
            string userString = Console.ReadLine().ToLower();//sets the user's response to all lower case

            bool inArray = false;//used to work error message

            for (int q = 0; q < songArray.Length; q++)//runs the length of the array
            {
                if (songArray[q].SongName.ToLower() == userString)//if their answer is in the array
                {
                    inArray = true;//set to true to not trigger the next if statement
                    Console.WriteLine(songArray[q].SongName + " is written by " + songArray[q].Artist + "\n");//prints the name of the song followed by the artist
                }
            }
            if (!inArray)//if their answer is not in the array
            {
                Console.WriteLine("The song " + userString + " is not there.\n");//prints when the user's response isn't in the array
            }
        }

        public void PrintBand()
        {
            Console.Write("Please enter a song name. ");
            string userString = Console.ReadLine().ToLower();//sets the user's response to all lower case

            bool inArray = false;// used to trigger the error message

            for (int q = 0; q < songArray.Length; q++)//runs the length of the array
            {
                if (songArray[q].SongName.ToLower() == userString)//if their response is in the array
                {
                    inArray = true;//set to true to not trigger the next if statement
                    Console.WriteLine(songArray[q].Band + " played " + songArray[q].SongName+"\n");//prints the band and then the song played by said band
                }
            }
            if (!inArray)//if their response is not in the array
            {
                Console.WriteLine("The song " + userString + " is not there.\n");//prints when the user's response isn't in the array
            }
        }
    }
}
