using System;
using System.Linq;

namespace Sandbox
{
    /// <summary>
    ///     Total all the values that are even numbers in the given array.
    /// </summary>
    public static class EvenArrayNumbers
    {
        public static void Run()
        {
            Console.Write("Enter Numbers by Spaces: ");

            var input = Console.ReadLine();
            if (input == null)
            {
                return;
            }

            var stringArray = input.Split(' ');
            var intArray = Array.ConvertAll(stringArray, int.Parse);

            var total = intArray.Where(i => i % 2 == 0).Sum();

            Console.WriteLine($"Total Number of even numbers are: {total}");
        }
    }
}