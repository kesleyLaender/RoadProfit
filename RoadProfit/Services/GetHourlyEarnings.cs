using System;
using RoadProfit.Models;

namespace RoadProfit.Services
{
    internal class GetHourlyEarnings
    {
        public static decimal Run(WorkDay workDay)
        {
            decimal hourlyEarnings = workDay.Revenue / (decimal)workDay.WorkedHours.TotalHours;
            return hourlyEarnings;
        }
    }
}
