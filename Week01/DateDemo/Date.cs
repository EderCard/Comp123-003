using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Date
    {
        //fields (all private)
        int year;
        int month;
        int day;
        public Date(int year, int month, int day)
        {
            this.year = year; //this refers to the members of the object. Only used when there is
            this.month = month;
            this.day = day;
        }
        public void Add(int days)
        {
            day += days;
            Normalize();
        }
        public void Add(int months, int days)
        {
            month += months;
            day += days;
            Normalize();
        }
        public void Add(Date other)
        {
            year += other.year;
            month += other.month;
            day += other.day;
            Normalize();
        }
        private void Normalize()
        {
            while (day > 30)
            {
                day -= 30;
                month++;
            }
            while (month > 12)
            {
                month -= 12;
                year++;
            }
        }
        string[] months = "Jan Feb Mar Apr May Jun Jul Aug Sep Oct Nov Dec".Split();
        public override string ToString()
        {
            //return $"{day:d2}-{month:d2}-{year}";
            return $"{months[month - 1]}, {day} {year}";
        }
    }
}
