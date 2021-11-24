using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("m = ");
        int m = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= m; i++)
        {
            int g = 0;
            while (g < i)
            {
                Console.Write("*");
                g++;
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }