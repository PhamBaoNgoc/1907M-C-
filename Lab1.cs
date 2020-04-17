using System;

namespace ConsoleApp1
{
    public class Lab1
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Moi nhap so n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int f = 0;
            int f1 = 1, f2 = 1;
            while (f1 + f2 < n)
            {
                f = f1 + f2;
                f2 = f1;
                f1 = f;
            }
            Console.WriteLine("Number = " + n + " Fibonacci = " + f);
        }
    }
}