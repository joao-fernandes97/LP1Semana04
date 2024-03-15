using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(n));
        }

        private static int GetSpecial(int n)
        {
            int seq;
            if(n==0)
                seq = 0;
            else if(n==1)
                seq = 1;
            else 
                seq = GetSpecial(n-1) + 2*GetSpecial(n-2);
            return seq;
        }
    }
}
