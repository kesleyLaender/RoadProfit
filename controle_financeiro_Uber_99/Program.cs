namespace controle_financeiro_Uber_99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Infome o seu faturamento bruto(ex: 150,00): ");
            decimal revenue = decimal.Parse(Console.ReadLine());
            Console.Write("Informe o KM percorrido(ex: 150): ");
            decimal KmDriven = decimal.Parse(Console.ReadLine());
            Console.Write("Digite as horas trabalhadas (ex: 08:30): ");
            decimal hoursWorked = (decimal)TimeSpan.Parse(Console.ReadLine()).TotalHours;
            Console.Write("Informe o preço do combustivel(ex: 5,80): ");
            decimal fuelPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Informe o consumo médio do seu carro(ex: 10): ");
            decimal fuelEfficiency = decimal.Parse(Console.ReadLine());
            decimal fuelCost = (KmDriven / fuelEfficiency) * fuelPrice;
            decimal netProfit = revenue - fuelCost;
            decimal profitPerHour = netProfit / hoursWorked;
            decimal profitPerKm = netProfit / KmDriven;
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
