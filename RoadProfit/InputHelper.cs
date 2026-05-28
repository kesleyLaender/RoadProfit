using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace RoadProfit
{
    internal class InputHelper
    {
        internal static decimal ReadPositiveDecimal(string message)
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

                if (!decimal.TryParse(input, out parsedValue))
                {
                    Console.WriteLine("Por favor digite apenas números.");
                    continue;
                }

                if (parsedValue <= 0)
                {
                    Console.WriteLine("Por favor, apenas valores positivos.");
                    continue;
                }

                return parsedValue;
            }

        }

        internal static decimal ReadWorkedHours(string message)
        {
            TimeSpan parsedHours;

            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Informe um valor válido");
                    continue;
                }

                if (!TimeSpan.TryParse(input, out parsedHours))
                {
                    Console.WriteLine("Formato esperado: 08:00");
                    continue;
                }

                return (decimal)parsedHours.TotalHours;
            }
        }
    }
}
