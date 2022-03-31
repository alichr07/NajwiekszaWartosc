using System;

namespace NajwiekszaWartosc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wyświetlanie największej liczby

            Console.WriteLine("Podaj a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b & a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > c & b > a)
            {
                Console.WriteLine(b);
            }
            else if (c > a & c > b)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
