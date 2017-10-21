using System;
using System.Linq;

namespace Sandbox
{
    /// <summary>
    ///     Converts a sentence to title case.
    /// </summary>
    public static class TitleCase
    {
        private static readonly string[] LowerCaseWords = {"a", "the", "to", "at", "in", "with", "and", "but", "or"};

        public static void Run()
        {
            Console.Write("Enter Sentence: ");

            var input = Console.ReadLine();
            if (input != string.Empty)
            {
                Console.WriteLine(Convert(input));
            }
        }

        private static string Convert(string sentence)
        {
            var normilzedSentence = sentence.ToLower();
            var words = normilzedSentence.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (i == 0 || i == words.Length - 1 || !LowerCaseWords.Contains(words[i]))
                {
                    words[i] = ToUpperCase(words[i]);
                }
            }

            return string.Join(" ", words);
        }

        private static string ToUpperCase(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}