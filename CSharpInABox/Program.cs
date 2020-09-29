using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;

namespace CSharpInABox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  read a file from your hard drive with a list of all Volcanoes
            List<Volcano> lVolcanoes = Volcano.LoadVolcanoData();

            //  Using the LINQ method Where get all Volcanoes since 2015
            var v2015 = lVolcanoes.Where(v => v.Year > 2015);

            //  Using the LINQ method ForEach print all Volcanoes since 2015
            v2015.ToList().ForEach(v => Console.WriteLine(v));

            //  Using LINQ count the deaths since 2015
            int deaths = v2015.Sum(v => v.Deaths);
            Console.WriteLine($"Since 1995 there have been {deaths} deaths from {v2015.Count()} eruptions");

            //  get all volcanoes for the 18th century 
            //  what is the average number of deaths where the number of deaths was greater than 0
            //  what was the total number of deaths 
            //  what was the max elevation
            //  order the volcanoes by elevation tallest to shortest
            //  what was the 'shortest' volcanoe (Last)
            //  get a list of the the 5th to 10th tallest volcanoes (Skip and Take)
        }
    }
}
