using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpInABox
{
    class WordLength
    {
        static void Main(string[] args)
        {
            string[] words = Utils.GetInput("Enter phrase").Split(" ");
            int[] wordLen = new int[60];

            //  let's do it with a single line of code
            words.ToList().ForEach(word => wordLen[word.Length]++);

            //  or we can do it with a for loop using an index
            for (int i = 0; i < words.Length; i++)
            {
                wordLen[words[i].Length]++;
            }

            //  or we can do it with a foreach loop
            foreach (var word in words)
            {
                wordLen[word.Length]++;
            }
            for (int i = 0; i < wordLen.Length; i++)
            {
                if (wordLen[i] == 0) continue;

                Console.WriteLine($"There were {wordLen[i],2} words {i,2} character{(i == 1 ? "" : "s")} long");
            }

        }
    }
}
