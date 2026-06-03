using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Globalization;

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

                string normalizedInput = input.Replace(",",".");

                if (!decimal.TryParse(normalizedInput,CultureInfo.InvariantCulture, out parsedValue))
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

                if(!input.Contains(':'))
                {
                    Console.WriteLine("Formato esperado: HH:MM");
                    continue;
                }

                if (!TimeSpan.TryParse(input, out parsedHours))
                {
                    Console.WriteLine("Formato esperado: 08:00");
                    continue;
                }

                if (parsedHours < TimeSpan.Zero)
                {
                    Console.WriteLine("Não pode ser negativo");
                    continue;
                }

                return (decimal)parsedHours.TotalHours;
            }
        }
        internal static int ReadPositiveInt(string message)
        {
            while(true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Valor inválido, tente novamente");
                    continue;
                }

                if (!int.TryParse(input, out int parsedValue))
                {
                    Console.WriteLine("Por favor, apenas numeros inteiros.");
                    continue;
                }

                if (parsedValue < 0)
                {
                    Console.WriteLine("Informe apenas números positivos por favor.");
                    continue;
                }

                return parsedValue;
            }
        }
    }
}
