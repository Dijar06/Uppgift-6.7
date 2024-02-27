using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal som du vill veta ifall det är ett primtal: ");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine(Metod(tal));
        }

        static bool Metod(int tal)
        {
            int deltal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (tal % i == 0)
                {
                    deltal++;
                }
            }
            if (deltal == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}