using System;
using System.Linq;

namespace TestTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumb = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = startNumb; i <= endNum; i++)

            {
                PrintNumbers(startNumb, i);
            }

            for (int i = endNum - 1; i >= startNumb; i--)
            {
                PrintNumbers(startNumb, i);
            }
        }

        static void PrintNumbers(int start, int limit)
        {
            for (int i = start; i <= limit; i++)
            {
                Console.Write($"{i} ");

            }

            Console.WriteLine();
        }
    }
}
