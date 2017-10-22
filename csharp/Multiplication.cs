using System;

namespace Sandbox
{
    /// <summary>
    ///     Displays the multiplication table vertically from 1 to n.
    /// </summary>
    public static class Multiplication
    {
        public static void Run()
        {
            Console.Write("Enter First Number: ");
            var pre = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            var input = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i <= input; i++)
            {
                Console.WriteLine($"{i} * {pre} = {i * pre}");
            }
        }
    }
}