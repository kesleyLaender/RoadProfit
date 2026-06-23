using System;
using System.Collections.Generic;
using System.Text;

namespace RoadProfit.Models
{
    public class Refuel
    {
        public DateTime Date {  get; set; }
        public int Odometer { get; set; }
        public decimal Liters { get; set; }
        public decimal PricePerLiter { get; set; }
        public decimal TotalValue { get; set; }
        public FuelType Fuel { get; set; }
    }
}
