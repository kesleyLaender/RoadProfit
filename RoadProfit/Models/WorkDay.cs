using System;
using System.Collections.Generic;
using System.Text;

namespace RoadProfit.Models
{
    public class WorkDay
    {
        public DateTime date{  get; set; }
        public PlatformType platform { get; set; }
        public decimal StartKm {  get; set; }
        public decimal EndKm { get; set; } 
        public decimal Revenue {  get; set; }
        public TimeSpan workedHours { get; set; }


    }
}
