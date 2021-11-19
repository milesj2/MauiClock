using System;

namespace MauiClock.Enums;

[Flags]
internal enum DayRepeat : long
{
    None = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 4,
    Thursday = 8, 
    Friday = 16,
    Saturday = 32,
    Sunday = 64
}
