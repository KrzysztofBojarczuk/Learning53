using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string again;
            do
            {
                Console.WriteLine("Rzucam kośćmi...");
                Console.WriteLine("Oto wynik:");
                Random rand = new Random();
                rand.Next(1, 6);
                Console.WriteLine(rand.Next(1, 6));
                Console.WriteLine(rand.Next(1, 6));

                Console.WriteLine("Chcesz wykonać kolejny rzut? (t = tak)");
                again = Console.ReadLine();

            } while (again == "t" || again == "T");
        }
    }
}
