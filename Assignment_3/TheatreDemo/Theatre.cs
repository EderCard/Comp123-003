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
    class Theatre
    {
        private List<Show> Shows;
        public string Name { get; }
        public Theatre(string name)
        {
            Name = name;
            Shows = new List<Show>();
        }
        public void AddShow(Show show)
        {
            Shows.Add(show);
        }
        public void PrintShows()
        {
            Console.WriteLine($"Theatre: {Name}");
            Console.WriteLine($"Filter: All shows");
            int count = 1;
            foreach (Show s in Shows)
            {
                Console.WriteLine($"{count++,2} {s}");
            }
        }
        public void PrintShows(Genre genre)
        {
            Console.WriteLine($"Theatre: {Name}");
            Console.WriteLine($"Filter (genre): {genre}");
            int count = 1;
            foreach (Show s in Shows)
            {
                if (s.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine($"{count++,-2} {s}");
                }
            }
        }
        public void PrintShows(Day day)
        {
            Console.WriteLine($"Theatre: {Name}");
            Console.WriteLine($"Filter (day): {day}");
            int count = 1;
            foreach (Show s in Shows)
            {
                if (s.Day == day)
                {
                    Console.WriteLine($"{count++,-2} {s}");
                }
            }
        }
        public void PrintShows(string actor)
        {
            Console.WriteLine($"Theatre: {Name}");
            Console.WriteLine($"Filter (actor): {actor}");
            int count = 1;
            foreach (Show s in Shows)
            {
                if(s.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine($"{count++,-2} {s}");
                }
            }
        }
        public void PrintShows(Time time)
        {
            Console.WriteLine($"Theatre: {Name}");
            Console.WriteLine($"Filter (time): {time}");
            int count = 1;
            foreach (Show s in Shows)
            {
                if (s.Time == time)
                {
                    Console.WriteLine($"{count++,-2} {s}");
                }
            }
        }
        public void PrintShows(Day day, Time time)
        {
            Console.WriteLine($"Theatre: {Name}");
            Console.WriteLine($"Filter (day, time): {day}, {time}");
            int count = 1;
            foreach (Show s in Shows)
            {
                if (s.Day == day && s.Time == time)
                {
                    Console.WriteLine($"{count++,-2} {s}");
                }
            }
        }
    }
}
