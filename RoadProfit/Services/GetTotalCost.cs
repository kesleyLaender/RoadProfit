using RoadProfit.Models;
using System;

namespace RoadProfit.Services
{
    internal class GetTotalCost
    {
        public static decimal Run(Refuel refuel, WorkDay workDay, decimal fuelEfficiency)
        {
            if (workDay.EndOdometer <= workDay.StartOdometer)
                return 0;

            int kmDriven = workDay.EndOdometer - workDay.StartOdometer;
            decimal totalCost = ((decimal)kmDriven / fuelEfficiency) * refuel.PricePerLiter;

            return totalCost;
        }
    }
}
