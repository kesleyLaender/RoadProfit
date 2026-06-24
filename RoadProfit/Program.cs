using RoadProfit.Helpers;
using RoadProfit.Models;
using RoadProfit.Services;


namespace RoadProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // --- INPUT SECTION ---

            decimal revenue = InputHelper.GetDecimal("Infome o seu faturamento bruto(ex: 150,00): ");
            decimal kmDriven = InputHelper.GetDecimal("Informe o KM percorrido(ex: 150): ");
            TimeSpan hoursWorked = InputHelper.GetTimeSpan("Informe a quantidade total de horas trabalhadas (ex: 08:00): ");
            decimal fuelPrice = InputHelper.GetDecimal("Informe o preço do combustivel(ex: 5,80): ");
            decimal fuelEfficiency = InputHelper.GetDecimal("Informe o consumo médio do seu carro(ex: 10): ");

            
            // --- LOGIC / CALCULATIONS ---

            decimal fuelCost = (kmDriven / fuelEfficiency) * fuelPrice;

            decimal netProfit = revenue - fuelCost;

            decimal profitPerHour = netProfit / (decimal)hoursWorked.TotalHours;

            decimal profitPerKm = netProfit / kmDriven;


            // --- OUTPUT SECTION ---

            Console.Clear();
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("------ RESUMO FINANCEIRO DO DIA ------");
            Console.WriteLine($"Custo estimado na media informada: {fuelCost:C2}");
            Console.WriteLine($"Lucro Liquido: {netProfit:C2}");
            Console.WriteLine($"Lucro por Km: {profitPerKm:C2}");
            Console.WriteLine($"Lucro por Hora: {profitPerHour:C2}");
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine("Obrigado, volte sempre!");
        }

    }
}
