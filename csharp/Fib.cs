using System;

namespace Sandbox
{
    /// <summary>
    ///     Outputs the nth fibonacci number.
    /// </summary>
    public static class Fib
    {
        public static void Run()
        {
            Console.Write("Enter Nth Number: ");

            var input = Console.ReadLine();
            if (input == string.Empty)
            {
                return;
            }

            var nth = Convert.ToInt32(input);

            var a = 0;
            var b = 1;

            Console.Write(a + " " + b + " ");

            for (var i = 2; i < nth; i++)
            {
                var c = a + b;
                Console.Write(c + " ");

                a = b;
                b = c;
            }
        }
    }
}