
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01
{






    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
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

        public Movies() { }

        public Movies(string title, string director, string description)
        {
            Title = title;
            Director = director;
            Description = description;

        }

        public Movies(int id, string title, string director, string description)
        {
            Id = id;
            Title = title;
            Director = director;
            Description = description;
        }




    }
}