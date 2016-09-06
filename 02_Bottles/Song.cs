using System;

namespace _02_Bottles
{
    internal class Song
    {
        public Song()
        {
        }

        internal string CountBottles(int bottles)
        {
            string mySong = "";
            for (int i = bottles; i > -1; i--)
            {
                if (i == 0)
                {
                    mySong = mySong + " No more bottles of beer on the wall.";
                }
                else if (i == 1)
                {
                    mySong = mySong + "1 bottle of beer on the wall. 1 bottle of beer." +
                    " Take one down and pass it around.";
                    bottles = bottles--;
                }
                else if (i == 2)
                {
                    mySong = mySong + bottles + " bottles of beer on the wall. "
                + bottles + " bottles of beer." + " Take one down and pass it around.";
                    bottles = bottles- 1;
                    mySong = mySong + " " + bottles + " bottle of beer on the wall. ";
                }
                else
                {
                    mySong = mySong + bottles + " bottles of beer on the wall. "
                + bottles + " bottles of beer." + " Take one down and pass it around.";
                    bottles = bottles- 1;
                    mySong = mySong + " " + bottles + " bottles of beer on the wall. ";
                }
            }
            return mySong;
        }
         
    }
}