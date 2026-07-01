using RoadProfit.Models;
using System;

namespace RoadProfit.Services
{
    internal class GetEarningsPerKm
    {
        public static decimal Run(WorkDay workDay)
        {
            if (workDay.EndOdometer <= workDay.StartOdometer)
                return 0;

            int kmDriven = GetKmDriven.Run(workDay);

            decimal earningsPerKm = workDay.Revenue / (decimal)kmDriven;

            return earningsPerKm;
        }
    }
}
