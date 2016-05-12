using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_AboodJonathan
{
    /*
    Author : Jonathan Abood
    Purpose : Child class that describes one rock band in the radio database. Inherits from Band.
    known errors : 
    */
    class RockBand : Band
    {
        //---private strings only the child class can use---\\
        private string leadVocalist;
        private string bassGuy;
        private string guitarGuy;
        private string drummerGuy;

        //--Constructor---\\
        public RockBand(string p_leadVocalist, string p_bassGuy, string p_guitarGuy, string p_dummerGuy, string p_bandName, string p_bandGenre) : base(p_bandName, p_bandGenre)
        {
            //---saves all the input and sets them to the variables the class can use---\\
            leadVocalist = p_leadVocalist;
            bassGuy = p_bassGuy;
            guitarGuy = p_guitarGuy;
            drummerGuy = p_dummerGuy;
        }

        //---Overrided Print, overrides the parent class(Band)---\\\
        public override void Print()
        {
            base.Print();//calls the base print 
            Console.WriteLine(leadVocalist+" is the lead vocalist.");//prints the band's the singer
            Console.WriteLine(bassGuy+" is the bass guy.");//prints the band's bass player
            Console.WriteLine(guitarGuy + " is the guitar guy.");//prints the band's guitar player
            Console.WriteLine(drummerGuy + " is the drummer guy.\n");//prints the band's drummer player
        }
    }
}
