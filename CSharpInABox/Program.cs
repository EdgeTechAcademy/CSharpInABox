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
            List<Volcano> lVolcanoes = Volcano.RetrieveVolcanoData();
            var v1985 = lVolcanoes.Where(v => v.Year > 1985);
            int deaths = v1985.Sum(v => v.Death);
            v1985.ToList().ForEach(v => Console.WriteLine(v));
            Console.WriteLine($"Deaths since 1985: {deaths}");
        }
    }
}
