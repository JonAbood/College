using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_AboodJonathan
{
    /*
    Author : Jonathan Abood
    Purpose : Child class that describes one solo artist in the radio database. Inherits from Band.
    known errors : unfinished
    */
    class SoloArtist : Band
    {
        //---private strings only the child class can use---\\
        private string soloArtistInstrument;

        //---Constructor---\\
        public SoloArtist(string p_soloArtistInstrument, string p_bandName, string p_bandGenre):base(p_bandName, p_bandGenre)
        {
            //---If the solo artist plays an instrument is will save it here---\\
            soloArtistInstrument = p_soloArtistInstrument;
        }

        //---Overrided Print, overrides the parent class(Band)---\\\
        public override void Print()
        {
            base.Print();//calls the base print 
            if (soloArtistInstrument != "")//If the solo artist does play an instrument 
            {
                Console.WriteLine(bandName+" plays "+soloArtistInstrument+".");//prints the solo artist's name and instrument
            }
            if(soloArtistInstrument == "")//If the solo artist does not play an instrument
            {
                Console.WriteLine(bandName+" is a singer.\n");//prints the solo artist's name and says they are a singer
            }

        }
    }
}
