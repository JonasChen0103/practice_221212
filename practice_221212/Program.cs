using System;

namespace practice_221212
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = (Convert.ToInt32(Console.ReadLine()));
            times(n, 1);
        }

        private static void times(int i, int j)
        {
            if(j <= 0 || j >= 10)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
                j++;
                times(i, j);
            }
        }
    }
}
