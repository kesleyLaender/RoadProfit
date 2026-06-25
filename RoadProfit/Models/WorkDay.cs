using System;
using System.Collections.Generic;
using System.Text;

namespace RoadProfit.Models
{
    public class WorkDay
    {
        public DateTime Date{  get; set; }
        public PlatformType Platform { get; set; }
        public int StartOdometer {  get; set; }
        public int EndOdometer { get; set; } 
        public decimal Revenue {  get; set; }
        public TimeSpan WorkedHours { get; set; }

    }
}
