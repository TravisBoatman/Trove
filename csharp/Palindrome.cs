using System;
using System.Linq;

namespace Sandbox
{
    /// <summary>
    ///     Checks if a word is a palindrome.
    /// </summary>
    public class Palindrome
    {
        public static void Run()
        {
            Console.Write("Enter a Word: ");

            var input = Console.ReadLine();

            if (input == string.Empty)
            {
                return;
            }

            var stringInput = Convert.ToString(input);
            var normalizedInput = stringInput.ToLower();

            var reversedInputEnumerable = normalizedInput.Reverse();
            var reversedInput = string.Concat(reversedInputEnumerable);

            Console.WriteLine(reversedInput == normalizedInput ? "Is Palindrome" : "Not a Palindrome");
        }
    }
}