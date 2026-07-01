using System;
using System.Globalization;

namespace RoadProfit.Helpers
{
    internal class GetDecimal
    {
        public static decimal Run(string message)
        {
            decimal parsedValue;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Por favor digite alguma coisa");
                    continue;
                }

                string normalizedInput = input.Replace(",", ".");

                if (!decimal.TryParse(normalizedInput, CultureInfo.InvariantCulture, out parsedValue))
                {
                    Console.WriteLine("Por favor digite apenas números.");
                    continue;
                }

                if (parsedValue < 0)
                {
                    Console.WriteLine("Por favor, apenas valores positivos.");
                    continue;
                }

                return parsedValue;
            }

        }
    }
}
