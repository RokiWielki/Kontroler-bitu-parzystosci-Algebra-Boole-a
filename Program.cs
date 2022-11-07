using System;
using System.Collections.Generic;

namespace Kontroler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManualTest();
            Console.WriteLine();
            Console.WriteLine("Aby kontynuować wciśnij dowolny przycisk...");
            Console.ReadKey();
            AllPossibilities();
        }
        public static void ManualTest()
        {
            Console.Write("Podaj cyfrę do sprawdzenia parzystości: ");

            string firstInput;
            while (true)
            {
                firstInput = Console.ReadLine().Trim();
                if (firstInput.Length == 4)
                {
                    if (int.TryParse(firstInput, out _))
                    {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(firstInput, Constants.BinaryStringValidate()))
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("Wprowadzono błędne dane!");
                Console.Write("Podaj pierwszą cyfrę (binarną, czterobitową): ");
            }

            int parity = Convert.ToInt32(firstInput, 2);

            if (parity % 2 == 0)
            {

                Console.Write(firstInput);
                Console.WriteLine(" 1");
                Console.WriteLine($"Liczba {parity} jest parzysta!");
            }
            else
            {

                Console.Write(firstInput);
                Console.WriteLine(" 0");
                Console.WriteLine($"Liczba {parity} jest nieparzysta!");
            }
        }

        private static void AllPossibilities()
        {
            int trials = 0;
            List<string> binary = Constants.BinaryInput();

            foreach (string variable in binary)
            {
                int baseCompare = Convert.ToInt32(variable, 2);
                Console.Write(variable);

                if (baseCompare % 2 == 0)
                {
                    Console.WriteLine(" 1");
                }
                else
                {
                    Console.WriteLine(" 0");
                }

                Console.WriteLine();
                trials++;
            }


            if (trials == 1)
                Console.WriteLine($"Wykonano: {trials} raz!");
            else
                Console.WriteLine($"Wykonano: {trials} razy!");
        }

    }
    public static class Constants
    {
        public static List<string> BinaryInput()
        {
            return new List<string>()
            {
                "0000",
                "0001",
                "0010",
                "0011",
                "0100",
                "0101",
                "0110",
                "0111",
                "1000",
                "1001",
                "1010",
                "1011",
                "1100",
                "1101",
                "1110",
                "1111"
            };
        }
        public static string BinaryStringValidate()
        {
            return "[2-9]+";
        }
    }
}
