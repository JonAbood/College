using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_AboodJonathan
{
    /*
    Author : Jonathan Abood
    Purpose : Describe one specific song in the radio database
    known errors : 
    */
    class Song
    {
        //---Private variables so only this class can use them---\\
        private string songName;
        private string artist;
        private string band;

        //---getSongName---\\
        public string SongName
        {
            get { return songName; }
        }

        //--getArtist---\\
        public string Artist
        {
            get { return artist; }
        }

        //---getBand---\\
        public string Band
        {
            get { return band; }
        }

        //---Constructor---\\
        public Song(string p_songName, string p_band, string p_artist)
        {
            //---saves all the input and sets them to the variables the class can use---\\
            songName = p_songName;
            artist = p_artist;
            band = p_band;
        }

        //---Print---\\
        public void Print()
        {
            Console.WriteLine(songName+" is covered by "+band+ " and written by "+artist+"\n");// prints song name followed by the artist, than band
        }
    }
}
