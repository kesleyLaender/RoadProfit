using System;
using RoadProfit.Models;
namespace RoadProfit.Services
{
    public class GetFuelEfficiency
    {
        public static decimal Run(Refuel refuel, int previousOdometer)
        {

            if (refuel.Liters == 0 || previousOdometer >= refuel.Odometer)
                return 0;

            int distanceTraveled = refuel.Odometer - previousOdometer;
            decimal fuelEfficiency = (decimal)distanceTraveled / refuel.Liters;

            return fuelEfficiency;
        }
    }
}
