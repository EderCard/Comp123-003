using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDemo
{
    enum TimeFormat { Mil, Hour12, Hour24 }
    class Time
    {
        static private TimeFormat TIME_FORMAT = TimeFormat.Hour12;
        public int Hour { get; private set; }
        public int Minute { get; private set; }

        public Time(int hours = 0, int minutes = 0)
        {
            if (hours <= 24)
                Hour = hours;
            else Hour = 0;

            if (minutes <= 60)
                Minute = minutes;
            else Minute = 0;
        }
        public override string ToString()
        {
            switch (TIME_FORMAT)
            {
                case TimeFormat.Mil:
                    return $"{Hour:d2}{Minute:d2}";
                case TimeFormat.Hour24:
                    return $"{Hour:d2}:{Minute:d2}";
                default:
                    return $"{Hour % 12}:{Minute:d2} {(Hour < 12 ? "AM":"PM")}";
            }
        }
        public static void SetFormat(TimeFormat newFormat)
        {
            TIME_FORMAT = newFormat;
        }
    }
}
