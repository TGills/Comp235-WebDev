using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string TItle { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }



    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }


    }
}