using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_AboodJonathan
{
    /*
    Author : Jonathan Abood
    Purpose : Parent class that describes one specific band in the radio database
              Parent of RockBand and SoloArtisti children
    known errors : 
    */
    class Band
    {
        //---Protected variables so the child classes can use them---\\
        protected string bandName;
        protected string bandGenre;

        //---getBandName---\\
        public string BandName
        {
            get { return bandName; }
        }

        //---getBandGenre---\\
        public string BandGenre
        {
            get { return bandGenre; }
        }

        //---Constructor---\\
        public Band(string p_bandName, string p_bandGenre)
        {
            //---saves all the input and sets them to the variables the class can use---\\
            bandName = p_bandName;
            bandGenre = p_bandGenre;
        }

        //---Virtual Print so the child classes can override it---\\
        public virtual void Print()
        {
            Console.WriteLine(bandName+" is a "+bandGenre+ "\n");//prints band name followed by its genre
        }
    }
}
