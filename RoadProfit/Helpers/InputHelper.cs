using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace RoadProfit.Helpers
{
    public class InputHelper
    {
        public static decimal GetDecimal(string message)
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

        public static TimeSpan GetTimeSpan(string message)
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

                if (!input.Contains(':'))
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

                return parsedHours;
            }
        }

        public static DateTime GetDate(string message)
        {
            DateTime parsedDate;            
            
            while(true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Por favor informe um valor válido");
                    continue;
                }

                boll isValid = DateTime.TryParseExact(
                    input,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out parsedDate
                    );

                if(!isValid)
                {
                    Console.WriteLine("Formato inválido! Use DD/MM/AAAA (ex: 22/06/2026)");
                    continue;
                }

                if(parsedDate > DateTime.Today)
                {
                    Console.WriteLine("Você não pode registrar uma data futura!");
                }

                return parsedDate;
            }

        }
    }
}

