using System;

namespace _02_Bottles
{
    internal class Song
    {
        public string bottleString, mySong;
        public string noBottles = " No more bottles of beer on the wall.";
        public string numberBottles = " of beer on the wall.";
        public string repeatBottles = " of beer. Take one down and pass it around.";

        public Song()
        {
        }

        internal string CountBottles(int bottles)
        {
            if (bottles == 0) return mySong + noBottles;
            bottleString = pluralDecider(bottles);
            mySong = mySong + bottleString + numberBottles + bottleString + repeatBottles;
            bottleString = pluralDecider(bottles- 1);
            if (bottles - 1 == 0) return CountBottles(bottles - 1);
            mySong = mySong + bottleString + numberBottles;
            return CountBottles(bottles-1);
        }
        internal string pluralDecider(int bottles)
        {
            string pluralized;
            if (bottles == 1) pluralized = " 1 bottle";
            else pluralized = " " + bottles + " bottles";
            return pluralized;
        } 
    }
}