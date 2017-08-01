using System;

namespace FizzBuzz
{
    class Program
    {
        private static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                var result = IsDivisble(i, 3, 5);
                
                if (result.Item1 && result.Item2)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (result.Item1)
                {
                    Console.WriteLine("Fizz");
                }
                else if (result.Item2)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static Tuple<bool, bool> IsDivisble(int x, int n, int y)
        {
            return new Tuple<bool, bool>(x % n == 0, x % y == 0);
        }
    }
}