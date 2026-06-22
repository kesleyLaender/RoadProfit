using System;
using System.Collections.Generic;
using System.Text;

namespace RoadProfit.Models
{
    internal class WorkDay
    {
        DateTime date{  get; set; }
        PlatformType platform { get; set; }
        decimal StartKm {  get; set; }
        decimal EndKm { get; set; } 
        decimal Revenue {  get; set; }
        TimeSpan workedHours { get; set; }


    }
}
