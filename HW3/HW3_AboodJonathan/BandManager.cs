using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_AboodJonathan
{
    /*
    Author : Jonathan Abood
    Purpose : Create an array of Ban Objects to interact with
    known errors : 
    */
    class BandManager
    {
        Band[] bandArray;//declares an array of bands

        //---BandManager---\\
        public BandManager()
        {
            bandArray = new Band[3];//sets the arrsy length to 3
            bandArray[0] = new SoloArtist("", "Logic", "Rap");//place in array
            bandArray[1] = new RockBand("Anthony Kiedis", "Flea", "John Frusciante", "Cahd Smith", "Red Hot Chili Peppers", "Classic Rock");//place in array
            bandArray[2] = new RockBand("David Draiman", "John Moyer", "Dan Donegan", "Mike Wengren", "Disturbed", "Metal");//place in array
        }

        //---PrintOneBand---\\
        public void PrintOneBand()
        {
            Console.Write("Please enter a band name. ");
            string userString = Console.ReadLine().ToLower();//sets the user's response to all lower case

            bool inArray = false;//used to trigger the error message

            for (int q = 0; q < bandArray.Length; q++)//runs the length of the array
            {
                if (bandArray[q].BandName.ToLower() == userString)//
                {
                    inArray = true;//set to true so the error message doesn't run 
                    bandArray[q].Print();//calls the print method
                }
            }
            if (!inArray)//if their answer isn't in the array
            {
                Console.WriteLine("The band " + userString + " is not there.\n");//prints when the user's response isn't in the array
            }
        }
        
        //---PrintBandType---\\
        public void PrintBandType()
        {
            Console.Write("Please enter a band name. ");
            string userString = Console.ReadLine().ToLower();//sets the user's response to all lower case

            bool inArray = false;//used to trigger the error message

            for (int q = 0; q < bandArray.Length; q++)//runs the length of the array
            {
                if (bandArray[q].BandName.ToLower() == userString)//if their response is in the array
                {
                    inArray = true;//set to true so the error message doesn't run
                    Console.WriteLine(bandArray[q].BandName+" is a "+bandArray[q].BandGenre+ "\n");//prints the band name followed by its type
                }
            }
            if (!inArray)//if their response isn't in the array
            {
                Console.WriteLine("The band " + userString + " is not there.\n");//prints when their response isn't in the array
            }
        }

        //---PrintAllBands---\\
        public void PrintAllBands()
        {
            for (int q = 0; q < bandArray.Length; q++)//runs the length of the array
            {
                bandArray[q].Print();//Calls the band print method
            }
        }
    }
}
