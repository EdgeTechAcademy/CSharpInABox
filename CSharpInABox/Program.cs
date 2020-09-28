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
            var v1995 = lVolcanoes.Where(v => v.Year > 1995);
            v1995.ToList().ForEach(v => Console.WriteLine(v));
            int deaths = v1995.Sum(v => v.Deaths);
            Console.WriteLine($"Deaths since 1995: {deaths} from {v1995.Count()} eruptions");
        }
    }
}
