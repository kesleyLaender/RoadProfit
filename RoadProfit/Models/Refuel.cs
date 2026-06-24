using System;
using RoadProfit.Services;


namespace RoadProfit.Models
{
    public class Refuel
    {
        public DateTime Date {  get; set; }
        public int Odometer { get; set; }
        public decimal Liters { get; set; }
        public decimal PricePerLiter { get; set; }
        public decimal TotalValue => Liters * PricePerLiter;
        public FuelType Fuel { get; set; }

        public decimal GetFuelEfficiecy (int previousOdometer)
        {

            if (Liters == 0 || previousOdometer >= Odometer)
                return 0;
            
            int distanceTraveled = Odometer - previousOdometer;
            decimal fuelEfficiency = (decimal)distanceTraveled / Liters;

            return fuelEfficiency;
        }
    }
}
