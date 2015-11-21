using System;
using Model;

namespace View
{
    class Program
    {
        static void Main()
        {
            var jay = new Jay();
            var silentBob = new SilentBob();
            var numbertron = new Numbertron();

            Console.Write("Enter a count of number: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || !(n > 0))
                Console.WriteLine("Incorect input!");

            numbertron.NewNumber += jay.FetchNewNumber;
            numbertron.NewNumber += silentBob.FetchNewNumber;

            for (int i = 0; i < n; i++)
                numbertron.Generate();

            if (jay.Score > silentBob.Score)
                    Console.WriteLine("Jay win!");
                else if (jay.Score < silentBob.Score)
                    Console.WriteLine("SilentBob win!");
                else
                    Console.WriteLine("DRAW");
            
            Console.ReadLine();
        }
    }
}
