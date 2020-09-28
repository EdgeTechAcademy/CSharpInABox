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
            string again;           //  do you want to play again?
            //  set up
            //      get all words in the english language and a random # generator
            string[] allWords = Utils.ReadFile("Dictionaries/Dictionary.txt");
            Random r = new Random();

            do
            {
                //  get a random number and choose a random word
                int rand = r.Next(allWords.Count());
                string wordToGuess = allWords[rand];

                //  need to track our progress. We will start with all underscores
                //  as we guess a letter it gets replaced with the letter
                char[] inProgress = "".PadLeft(wordToGuess.Length, '_').ToCharArray();
                int tryCount = 1;

                while (true)
                {
                    Console.WriteLine(wordToGuess);
                    Console.WriteLine(string.Join("", inProgress));
                    string guess = Utils.GetInput("Enter Letter:").ToLower();
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i].Equals(guess[0]))
                        {
                            inProgress[i] = guess[0];
                        }
                    }
                    if (wordToGuess.Equals(string.Join("", inProgress)))
                    {
                        Console.WriteLine($"Done! in {tryCount} attempts");
                        break;
                    }
                    tryCount++;
                    if ( tryCount > 10)
                    {
                        Console.WriteLine($"Too many attempts. The word was {wordToGuess}");
                    }
                }
                again = Utils.GetInput("Want to play again?").ToLower();
            } while (again.Equals("y"));


            List<Volcano> lVolcanoes = Volcano.RetrieveVolcanoData();
            var v1985 = lVolcanoes.Where(v => v.Year > 1985);
            int deaths = v1985.Sum(v => v.Death);
            v1985.ToList().ForEach(v => Console.WriteLine(v));
            Console.WriteLine($"Deaths since 1985: {deaths}");

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
