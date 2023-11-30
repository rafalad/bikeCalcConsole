using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikeCalcConsole
{
    public class CalculatePower
    {
        public static string Power()
        {
            Console.WriteLine("Hill Climb Power Calculator");

            // Wczytywanie danych od użytkownika dla wagi 1
            double totalWeight1 = GetTotalWeight("Podaj masę roweru i jeźdźca dla wagi 1 (kg): ");
            double elevationGain = GetElevationGain("Podaj przewyższenie (metry): ");
            double targetTime = GetTargetTime("Podaj docelowy czas (sekundy): ");

            // Obliczenie mocy wymaganej dla wagi 1 do pokonania podjazdu
            double powerRequired1 = CalculatePowerRequired(totalWeight1, elevationGain, targetTime);

            // Wczytywanie danych od użytkownika dla wagi 2
            double totalWeight2 = GetTotalWeight("Podaj masę roweru i jeźdźca dla wagi 2 (kg): ");

            // Obliczenie mocy wymaganej dla wagi 2 do pokonania podjazdu
            double powerRequired2 = CalculatePowerRequired(totalWeight2, elevationGain, targetTime);

            // Wyświetlanie wyników i porównywanie
            Console.WriteLine($"Moc wymagana do pokonania podjazdu dla wagi 1 wynosi {powerRequired1} wattów.");
            Console.WriteLine($"Moc wymagana do pokonania podjazdu dla wagi 2 wynosi {powerRequired2} wattów.");

            CompareWeights(powerRequired1, powerRequired2);
        }

        static double GetTotalWeight(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        static double GetElevationGain(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        static double GetTargetTime(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        static double CalculatePowerRequired(double totalWeight, double elevationGain, double targetTime)
        {
            double rollingResistanceAndWindResistanceFactor = 1.1; // Dodajemy 10% na opór toczenia i opór powietrza

            double powerRequired = totalWeight * 9.8 * elevationGain / targetTime * rollingResistanceAndWindResistanceFactor;

            return powerRequired;
        }

        static void CompareWeights(double powerRequired1, double powerRequired2)
        {
            if (powerRequired1 < powerRequired2)
            {
                Console.WriteLine("Waga 1 jest korzystniejsza pod względem mocy wymaganej.");
            }
            else if (powerRequired1 > powerRequired2)
            {
                Console.WriteLine("Waga 2 jest korzystniejsza pod względem mocy wymaganej.");
            }
            else
            {
                Console.WriteLine("Wagi 1 i 2 wymagają tej samej mocy do pokonania podjazdu.");
            }
        }
    }
}
