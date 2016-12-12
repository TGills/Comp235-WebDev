using System;
using Lab01;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
namespace Lab01
{
    public class MovieCategory
    {
        public string connectionString;
        public int ID { get; set; }
        public string Name { get; set; }
        public MovieCategory()
        {
            connectionString = WebConfigurationManager.ConnectionStrings["dbMovies1"].ConnectionString;
        }
        public MovieCategory(int id, string name)
        {
            ID = id;
            Name = name;
        }
        



































        




    }
}