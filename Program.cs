using System;

namespace HillClimbCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hill Climb Calculator");

                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("Wybierz opcję:");
                    Console.WriteLine("1. Obliczenie potrzebnej mocy");
                    Console.WriteLine("2. Obliczenie potrzebnego czasu");
                    Console.WriteLine("3. Zakończ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            CalculatePower();
                            break;
                        case "2":
                            CalculateTime();
                            break;
                        case "3":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Nieprawidłowy wybór. Wybierz opcję od 1 do 3.");
                            break;
                    }
                }
            }


















            
        }

        
    }
}
