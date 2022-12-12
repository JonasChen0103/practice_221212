using System;

namespace practice_221212
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var isNumber = double.TryParse(input, out var num);

            if (!isNumber)
            {
                Console.WriteLine("請輸入數值");
                return;
            }

            ShowMultiplication(num, 1);
        }

        private static void ShowMultiplication(double num, int times)
        {
            if (times >= 10) 
                return;

            Console.WriteLine($"{num} * {times} = {num * times}");
            ShowMultiplication(num, times + 1);
        }
    }
}
