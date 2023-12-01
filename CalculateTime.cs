using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikeCalcConsole
{
    public class CalculateTime
    {
        public static void RunCalculation()
        {
            Console.WriteLine("Obliczanie potrzebnego czasu...");

            // Wczytywanie danych od użytkownika
            Console.Write("Podaj masę roweru i jeźdźca (kg): ");
            double totalWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj przewyższenie (metry): ");
            double elevationGain = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj moc roweru (watt): ");
            double powerRequired = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj długość podjazdu (metry): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            // Obliczenie docelowego czasu
            double timeRequired = CalculateTargetTime(totalWeight, elevationGain, powerRequired, distance);

            Console.WriteLine($"Potrzebny czas do pokonania podjazdu wynosi {timeRequired} sekund.");
        }


        private static double CalculateTargetTime(double totalWeight, double elevationGain, double powerRequired, double distance)
        {
            double rollingResistanceAndWindResistanceFactor = 1.1; // Dodajemy 10% na opór toczenia i opór powietrza

            double targetTime = (distance + totalWeight * 9.8 * elevationGain) / (powerRequired * rollingResistanceAndWindResistanceFactor);

            return targetTime;
        }
    }
}
