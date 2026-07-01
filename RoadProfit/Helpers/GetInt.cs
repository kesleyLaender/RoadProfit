using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace RoadProfit.Helpers
{
    internal class GetInt
    {
        public static int Run(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            int parsedValue;
            while (true)
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Informe um valor válido");
                    continue;
                }

                if (!int.TryParse(input, out parsedValue))
                {
                    Console.WriteLine("Por favor, informe apenas números");
                    continue;
                }

                if (parsedValue < 0)
                {
                    Console.WriteLine("Apenas números positivos");
                    continue;
                }
                return parsedValue;
            }
        }
    }
}
