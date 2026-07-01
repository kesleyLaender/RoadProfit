using System;
using System.Globalization;

namespace RoadProfit.Helpers
{
    public class GetTimeSpan
    {

        public static TimeSpan Run(string message)
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

    }
}

