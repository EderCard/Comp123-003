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
    class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; } 
        public List<string> Cast { get; private set; } 
        public Movie(string name, int year, int length)
        {
            Title = name;
            Year = year;
            Length = length;
            Cast = new List<string>();  
        }
        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }
        public void SetGenre(Genre genre)
        {
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{Title} Genre:{Genre} Length:{Length} Year:{Year} \n   Cast:{string.Join(", ", Cast)}"; 
        }
    }
}
