using System;

namespace Sandbox
{
    /// <summary>
    ///     Removes the 2nd and 3rd occurrence of the specified character in a given sentence.
    /// </summary>
    public static class RemoveCharacters
    {
        public static void Run()
        {
            Console.Write("Enter Sentence with Three $ Characters: ");

            var input = Console.ReadLine();
            if (input == null)
            {
                return;
            }

            var startValue = input.IndexOf('$');

            var secondValue = input.IndexOf('$', startValue + 1);
            var thirdValue = input.IndexOf('$', secondValue + 1);

            var s = input.Remove(secondValue, 1);
            var st = s.Remove(thirdValue -1, 1);

            Console.WriteLine(st);
        }
    }
}