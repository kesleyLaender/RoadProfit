using RoadProfit.Models;
using System;

namespace RoadProfit.Services
{
    internal class GetEarningsPerKm
    {
        public static int Run(WorkDay workDay)
        {
            if (workDay.EndOdometer <= workDay.StartOdometer)
                return 0;

            int kmDriven = workDay.EndOdometer - workDay.StartOdometer;

            decimal earningsPerKm = workDay.Revenue / kmDriven;

            return kmDriven;
        }
    }
}
