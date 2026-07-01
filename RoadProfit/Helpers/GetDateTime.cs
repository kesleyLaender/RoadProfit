using System;
using System.Globalization;


namespace RoadProfit.Helpers
{
    internal class GetDateTime
    {
        public static DateTime Run(string message)
        {
            DateTime parsedDate;

            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Por favor informe um valor válido");
                    continue;
                }

                bool isValid = DateTime.TryParseExact(
                    input,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out parsedDate
                    );

                if (!isValid)
                {
                    Console.WriteLine("Formato inválido! Use DD/MM/AAAA (ex: 22/06/2026)");
                    continue;
                }

                if (parsedDate > DateTime.Today)
                {
                    Console.WriteLine("Você não pode registrar uma data futura!");
                }

                return parsedDate;
            }

        }
    }
}
