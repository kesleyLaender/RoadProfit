using System;
using RoadProfit.Services;
namespace RoadProfit.Models
{
    public class Maintenance
    {
        public DateTime Date { get; set; }
        public int Odometer {  get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal TotalValue { get; set; }
        public MaintenanceType Type {  get; set; }
    }
}
