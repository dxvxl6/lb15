namespace lb15
{
    using System;
    using System.Linq;
    class Program
    {
        static int MultiplyUsingLoop(int a, int b)
        {
            int result = 0;
            bool isNegative = false;
            if (a < 0)
            {
                a = -a;
                isNegative = !isNegative;
            }
            if (b < 0)
            {
                b = -b;
                isNegative = !isNegative;
            }
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return isNegative ? -result : result;
        }
        static int MultiplyUsingRecursion(int a, int b)
        {
            if (b == 0)
                return 0;
            if (b > 0)
                return a + MultiplyUsingRecursion(a, b - 1);
            return -MultiplyUsingRecursion(a, -b);
        }
        static int MultiplyUsingBitwise(int a, int b)
        {
            int result = 0;
            bool isNegative = (a < 0) ^ (b < 0);
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b > 0)
            {
                if ((b & 1) == 1)
                    result += a;
                b >>= 1; 
            }
            return isNegative ? -result : result;
        }
        static int MultiplyUsingRepeat(int a, int b)
        {
            if (b == 0) return 0;
            return a > 0 ? Enumerable.Repeat(a, b).Sum() : -Enumerable.Repeat(-a, -b).Sum();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MultiplyUsingLoop(x, y));
            Console.WriteLine(MultiplyUsingRecursion(x, y));
            Console.WriteLine(MultiplyUsingBitwise(x, y));
            Console.WriteLine(MultiplyUsingRepeat(x, y));
        }

    }

}
