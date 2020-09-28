using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpInABox
{
    class Hangman
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
                    if (tryCount > 10)
                    {
                        Console.WriteLine($"Too many attempts. The word was {wordToGuess}");
                    }
                }
                again = Utils.GetInput("Want to play again?").ToLower();
            } while (again.Equals("y"));
        }
    }
}
