using RoadProfit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoadProfit.Services
{
    internal class GetNetProfit
    {
        public static decimal Run(WorkDay workDay, decimal totalCost)
        {
            decimal netProfit = workDay.Revenue - totalCost;

            return netProfit;
        }
    }
}
