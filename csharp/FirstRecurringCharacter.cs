using System;
using System.Collections;
using System.Linq;

namespace Sandbox
{
    /// <summary>
    ///     Finds the first recurring character in the given string.
    /// </summary>
    public class FirstRecurringCharacter
    {
        public static void Run()
        {
            Console.Write("Input characters with at least one recurring character: ");

            var input = Console.ReadLine().ToArray();
            var hash = new Hashtable();

            foreach (var character in input)
            {
                if (hash.Contains(character))
                {
                    Console.WriteLine(character);
                    break;
                }
                else
                {
                    hash.Add(character, 1);
                }
            }
        }
    }
}
