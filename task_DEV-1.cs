using System;

namespace Numbers
{
    class Program
    {
        static void Main()
        {
            for (int n = 0; n <= 100; n++)
            {
                if ((n % 3 == 0) && (n % 5 == 0))
                {
                    Console.WriteLine("Tutti-Frutti");
                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine("Tutti");
                }
                else if (n % 5 == 0)
                {
                    Console.WriteLine("Frutti");
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadLine();
        }
    }
}
