using RoadProfit.Models;
using System;

namespace RoadProfit.Services
{
    internal class GetKmDriven
    {
        public static int Run(WorkDay workDay)
        {
            if(workDay.EndOdometer <= workDay.StartOdometer)
            {
                return 0;
            }

            return workDay.EndOdometer - workDay.StartOdometer;
        }
    }
}
