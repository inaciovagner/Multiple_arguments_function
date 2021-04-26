using System;
namespace CsharpPrograms
{
    class Program
    {
        static public int Add(int a, int b)
        {
            return a + b;
        }
        static public int Add(int a, int b, int c = 0)

        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            int x, y, z, result = 0;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            if (z > 0 || z < 0)
            {
                result = Add(x, y, z);
            }
            else
            {
                result = Add(x, y);
            }
            Console.WriteLine(result);
        }
    }
}