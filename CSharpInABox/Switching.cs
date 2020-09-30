using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInABox
{
    class Switching
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string dp = Utils.GetInput("Enter Date Part: ");
                if (dp.Length == 0)
                    break;
                int num = GetDatePart(dp);
                Console.WriteLine($"{dp} value is {num}");
            }


            //11.Ask the user for a letter. Switch on letter and for each letter create a variable with “A is for Apple”, “B is for …”
            string phrase = "";
            while (true)
            {
                string letter = Utils.GetInput("Type a letter: ").ToUpper();
                if (letter.Length == 0)
                {
                    Console.WriteLine("Empty string we are done");
                    break;
                }
                switch(letter[0])
                {
                    case 'A': phrase = "A is for Apple"; break;
                    case 'B': phrase = "B is for Boy"; break;
                    case 'C': phrase = "C is for Cow"; break;
                    case 'D': phrase = "D is for Dog"; break;
                    case 'E': phrase = "E is for Elephant"; break;
                    case 'F': phrase = "F is for Frog"; break;
                    case 'G': phrase = "G is for Girl"; break;
                    case 'H': phrase = "H is for Horse"; break;
                    case 'I': phrase = "I is for Igloo"; break;
                    case 'J': phrase = "J is for Jello"; break;
                    case 'K': phrase = "K is for Kangaroo"; break;
                    case 'L': phrase = "L is for Lion"; break;
                    case 'M': phrase = "M is for Mouse"; break;
                    case 'N': phrase = "N is for Nose"; break;
                    case 'O': phrase = "O is for O"; break;
                    case 'P': phrase = "P is for P"; break;
                    case 'Q': phrase = "Q is for Q"; break;
                    case 'R': phrase = "R is for R"; break;
                    case 'S': phrase = "S is for S"; break;
                    case 'T': phrase = "T is for T"; break;
                    case 'U': phrase = "U is for U"; break;
                    case 'V': phrase = "V is for V"; break;
                    case 'W': phrase = "W is for W"; break;
                    case 'X': phrase = "X is for X"; break;
                    case 'Y': phrase = "Y is for Y"; break;
                    case 'Z': phrase = "Z is for Z"; break;
                    default: phrase = $"{letter} is unknown"; break;
                }
                Console.WriteLine(phrase);
            }

            //12.Ask for a state abbreviation.Switch on it and save the name of the state to a variable
            //13.Ask for an hour of the day(0 - 24).Switch on the hour and save what you are doing at that time to a variable.
            int hour = Utils.GetNumber("What hour is it?");
            string whatAreYouDoing = "";
            switch (hour)
            {
                case 0: whatAreYouDoing = "Sleeping"; break;
                case 1: whatAreYouDoing = "Sleeping"; break;
                case 2: whatAreYouDoing = "Sleeping"; break;
                case 3: whatAreYouDoing = "Sleeping"; break;
                case 4: whatAreYouDoing = "Sleeping"; break;
                case 5: whatAreYouDoing = "Sleeping"; break;
                case 6: whatAreYouDoing = "Wake Up"; break;
                case 7: whatAreYouDoing = "Driving to ETA"; break;
                case 8: whatAreYouDoing = "Teaching"; break;
                case 9: whatAreYouDoing = "Teaching"; break;
                case 10: whatAreYouDoing = "Teaching"; break;
                case 11: whatAreYouDoing = "Teaching"; break;
                case 12: whatAreYouDoing = "Teaching"; break;
                case 13: whatAreYouDoing = "Teaching"; break;
                case 14: whatAreYouDoing = "Email"; break;
                case 15: whatAreYouDoing = "Lunch"; break;
                case 16: whatAreYouDoing = "Exec Dir Stuff"; break;
                case 17: whatAreYouDoing = "Exec Dir Stuff"; break;
                case 18: whatAreYouDoing = "Teaching"; break;
                case 19: whatAreYouDoing = "Teaching"; break;
                case 20: whatAreYouDoing = "Teaching"; break;
                case 21: whatAreYouDoing = "Teaching"; break;
                case 22: whatAreYouDoing = "Teaching"; break;
                case 23: whatAreYouDoing = "Brush teeth and read my scriptures"; break;
            }
            Console.WriteLine($"At {hour} o'clock I am {whatAreYouDoing}");
            //14.Ask for a number of a month(1 - 12).Switch on the number and assign to a variable the season to which the month belongs.
            //15.Ask for a Zodiac sign.Switch on the sign and save the horoscope to a variable
            string zodiak = Utils.GetInput("What's your sign? ");
            string horoscope = "";
            switch(zodiak.ToLower())
            {
                case "aries": horoscope = "Don't eat any frogs today"; break;
                case "taurus": horoscope = "Today will be good day to learn C#"; break;
            }
            Console.WriteLine($"The horoscope for a {zodiak} today is {horoscope}");

        }           //  end of main

        /**
         *  GetDatePart
         *      input
         *          part    string parameter that contains one of these options h,m,s,Y,M,D,WY,DY,DM
         *      output
         *          int     the value of the date asked for number of hour or min or day of month
         * 
         * 
         */
        static int GetDatePart(string part)
        {
            int number;
            DateTime dateTime = DateTime.Now;

            switch (part.ToLower())
            {
                case "h": number = dateTime.Hour; break;
                case "dm": number = dateTime.Day; break;
                case "dy": number = dateTime.DayOfYear; break;
                default: number = -1;   break;
            }

            return number;
        }
    }
}
