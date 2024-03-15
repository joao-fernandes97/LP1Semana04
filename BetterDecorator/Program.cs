using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            char dec = char.Parse(args[1]);
            int n = int.Parse(args[2]);
            Console.WriteLine(Decor(args[0], dec, n));
            
        }

        private static string Decor(string s, char dec, int n)
        {
            string sen = "";
            for (int i = 0; i < n; i++)
            {
                sen += dec;
            }
            sen += $" {s} ";
            for (int i = 0; i < n; i++)
            {
                sen += dec;
            }

            return sen;
        }
    }
}
