using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// Receives command line arguments, parses them
        /// to the correct format and calls the Decor
        /// method with them
        /// </summary>
        /// <param name="args">command line arguments,
        /// expects 3 of them in order:
        /// - a sentence
        /// - a single character
        /// - a number</param>
        static void Main(string[] args)
        {
            if(args.Length==0)
            {
                Console.WriteLine(Decor());
            }else{
                char dec = char.Parse(args[1]);
                int n = int.Parse(args[2]);
                Console.WriteLine(Decor(args[0], dec, n));
            }
            
            
        }

        /// <summary>
        /// Receives 3 parameters and builds a sentence with
        /// them
        /// </summary>
        /// <param name="s">center portion of the sentence</param>
        /// <param name="dec">decorator character</param>
        /// <param name="n">how many times that character is repeated on 
        /// each side</param>
        /// <returns>the new adorned sentence</returns>
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

        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
