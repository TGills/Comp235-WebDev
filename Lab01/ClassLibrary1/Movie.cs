using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Movie
/// </summary>
namespace MovieLibrary
{
    public class Movie
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public bool InTheaters { get; set; }
        public string Director { get; set; }

        public int CategoryId { get; set; }

        string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (value != null)
                    _description = value;
                else
                    value = "No description available";
            }
        }

        public Movie() { }

        public Movie(int id)
        {
            Id = id;
        }

        public Movie(string title, string director, string description)
        {
            Title = title;
            Director = director;
            Description = description;

        }

        public Movie(int id, string title, string director, string description)
        {
            Id = id;
            Title = title;
            Director = director;
            Description = description;
        }

        public Movie(int id, string title, string director, string description, bool inTheaters)
        {
            Id = id;
            Title = title;
            Director = director;
            Description = description;
            InTheaters = inTheaters;
        }

        public Movie(int id, string title, string director, string description, bool inTheaters, int catId)
        {
            Id = id;
            Title = title;
            Director = director;
            Description = description;
            InTheaters = inTheaters;
            CategoryId = catId;
        }







    }
}