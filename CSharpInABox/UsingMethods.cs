using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInABox
{
    class UsingMethods
    {
        static void Main(string[] args)
        {
            string[] arrName = { "Edge Tech Academy" };
            string strName = "Edge Tech Academy";
            int[] arNum = { 999 };
            int iNum = 999;

            Console.WriteLine($"Before: arrName[0] {arrName[0]} strName {strName} arNum[0] {arNum[0]} iNum {iNum}");
            ChangeName(arrName, arNum);
            ChangeName(strName, iNum);
            Console.WriteLine($"After : arrName[0] {arrName[0]} strName {strName} arNum[0] {arNum[0]} iNum {iNum}");
            Console.ReadLine();

            SayHi();        //  call to static method
            SayHi("Dave");
            SayHi("Edge Tech");

            Sing();         //  call to static method
            Sing("Daisy");
            Sing("Edge Tech");

            string greeting;
            greeting = CreateGreeting("Edge Tech", "USA");
            Console.WriteLine(greeting);
            greeting = CreateGreeting("Brandon", "fra");
            Console.WriteLine(greeting);
            greeting = CreateGreeting("Amber", "arabic");
            Console.WriteLine(greeting);
            greeting = CreateGreeting("Gary", "nld");
            Console.WriteLine(greeting);
        }

        private static void ChangeName(string nameParam, int num)
        {
            nameParam = "Did name change??";
            num = -1;
        }

        private static void ChangeName(string[] nameParm, int[] intArray)
        {
            nameParm[0] = "Did name change??";
            intArray[0] = -1;
        }

        private static string CreateGreeting(string name, string country)
        {
            string hello;           //  this is the first line. We need a return variable

            switch (country.ToLower())
            {
                case "usa": hello = $"Hello {name}! Glad you are here"; break;
                case "fra": hello = $"Bonne journée {name}! heureux que vous êtes ici"; break;
                case "arabic": hello = $"يوم سعيد {name}! سعيد لأنك هنا"; break;
                case "mex": hello = $"Hola {name}! Me alegro de que estés aquí"; break;
                case "nld": hello = $"Goeden dag {name}! blij dat je hier bent"; break;
                default: hello = $"Welcome {name} to Edge Tech"; break;
            }
            return hello;           //  this is the last line
        }

        static void SayHi()
        {
            Console.WriteLine("Hello, Dave... I am HAL 9000");
        }
        static void SayHi(string name)
        {
            Console.WriteLine($"Hello, {name}... I am HAL 9000");
        }

        static void Sing()
        {
            Console.WriteLine("Daisy, Daisy, give me your answer true...");
        }
        static void Sing(string name)
        {
            Console.WriteLine($"{name}, {name}, give me your answer true...");
        }
    }
}
