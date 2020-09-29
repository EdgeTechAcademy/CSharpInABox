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
            int deaths = v2015.Sum(v => v.Deaths);
            Console.WriteLine($"Since 1995 there have been {deaths} deaths from {v2015.Count()} eruptions");
        }
    }
}
