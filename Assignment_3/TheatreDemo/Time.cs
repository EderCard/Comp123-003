using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Assignment 3 - Theater
 * Ederson Cardoso  ID: 301033332
 * Andrew Cheung    ID: 300604147
 * Haeun Jeong      ID: 301004579
 * Sayda Rahman     ID: 301042327
 */
namespace TheatreDemo
{
    class Time
    {
        const int TIMELIMIT = 15;
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }
        public Time(int hours, int minutes, int seconds = 0)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public override string ToString()
        {
            return $"{Hours:d2}:{Minutes:d2}:{Seconds:d2}";
        }
        public static bool operator ==(Time lhs, Time rhs)
        {
            int difference = Math.Abs((lhs.Hours * 60 + lhs.Minutes) - (rhs.Hours * 60 + rhs.Minutes));
            if (difference < TIMELIMIT)
                return true;
            else
                return false;
        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            int difference = Math.Abs((lhs.Hours * 60 + lhs.Minutes) - (rhs.Hours * 60 + rhs.Minutes));
            if (difference > TIMELIMIT)
                return true;
            else
                return false;
        }
    }
}

