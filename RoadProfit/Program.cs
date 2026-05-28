namespace RoadProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- INPUT SECTION ---
            // Nota: Usando .Parse temporariamente para estruturar a lógica. 
            // Próxima sprint: Implementar TryParse e loops de validação para evitar exceções de entrada.

            decimal revenue = InputHelper.ReadPositiveDecimal("Infome o seu faturamento bruto(ex: 150,00): ");
            decimal KmDriven = InputHelper.ReadPositiveDecimal("Informe o KM percorrido(ex: 150): ");
            decimal hoursWorked = InputHelper.ReadWorkedHours("Informe Quantidade de horas você trabalhou hoje(ex: 08:00): ");
            decimal fuelPrice = InputHelper.ReadPositiveDecimal("Informe o preço do combustivel(ex: 5,80): ");
            decimal fuelEfficiency = InputHelper.ReadPositiveDecimal("Informe o consumo médio do seu carro(ex: 10): ");

            
            // --- LOGIC / CALCULATIONS ---

            // Cálculo do custo estimado baseado na eficiência média (km/l)
            decimal fuelCost = (KmDriven / fuelEfficiency) * fuelPrice;

            // Lucro Líquido (Net Profit): Faturamento menos custo de combustível
            decimal netProfit = revenue - fuelCost;

            // Médias de rentabilidade por tempo e por distância
            decimal profitPerHour = netProfit / hoursWorked;
            decimal profitPerKm = netProfit / KmDriven;

            
            // --- OUTPUT SECTION ---
            // Exibição dos resultados formatados como moeda (C2)
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
