using MauiClock.Enums;
using System;

namespace MauiClock.ViewModels
{
    internal class AlarmViewModel
    {
        public string AlarmName { get; set; }

        public TimeOnly Time { get; set; }
        
        public DayRepeat Repeat { get; set; }

    }
}
