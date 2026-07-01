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

            DateTime date = GetDateTime.Run("informe a data do abastecimento ex(DD/MM/AAAA)");
            decimal revenue = GetDecimal.Run("Infome o seu faturamento bruto(ex: 150,00): ");
            int startOdometer = GetInt.Run("Informe o odômetro inicial(ex: 150): ");
            int endOdometer = GetInt.Run("Informe o odômetro final");
            TimeSpan hoursWorked = GetTimeSpan.Run("Informe a quantidade total de horas trabalhadas (ex: 08:00): ");
            decimal fuelPrice = GetDecimal.Run("Informe o preço do combustivel(ex: 5,80): ");
            decimal fuelEfficiency = GetDecimal.Run("Informe o consumo médio do seu carro(ex: 10): ");


            // --- LOGIC / CALCULATIONS ---

            int kmDriven = endOdometer - startOdometer;

            decimal fuelCost = ((decimal)kmDriven / fuelEfficiency) * fuelPrice;

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
