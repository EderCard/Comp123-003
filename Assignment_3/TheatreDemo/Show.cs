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
    class Show
    {
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }
        public Show(Movie movie, Day day, double price, Time time)
        {
            Price = price;
            Day = day;
            Movie = movie;
            Time = time;
        }
        public override string ToString()
        {
            return $"Day:{Day} Time:{Time} Price:{Price:C} Movie:{Movie}";
        }
    }
}
