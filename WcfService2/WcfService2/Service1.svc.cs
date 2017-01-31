using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Configuration;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>();
            SqlConnection con =
                new SqlConnection
                (WebConfigurationManager.ConnectionStrings["dbMovies"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select Title, Director, Description From Movies");
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Movie m = new Movie(reader["Title"].ToString(),
                                    reader["Director"].ToString(),
                                    reader["Description"].ToString());
                movies.Add(m);
            }
            return movies;
        }
        
        public List<MovieCategory> getAllMovieCategories()
        {
            List<MovieCategory> movieCategories = new List<MovieCategory>();
            SqlConnection con =
                new SqlConnection
                (WebConfigurationManager.ConnectionStrings["dbMovies"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select Id, Name From MovieCategories");
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MovieCategory mc = new MovieCategory(Convert.ToInt32(reader["Id"].ToString()),
                                    reader["Name"].ToString());
                movieCategories.Add(mc);
            }

            return movieCategories;
        }

        public List<Movie> getAllMoviesByCategory(int catId)
        {
            List<Movie> movieCategories = new List<Movie>();

            SqlConnection con =
                new SqlConnection
                (WebConfigurationManager.ConnectionStrings["dbMovies"].ConnectionString);

            SqlCommand cmd = new SqlCommand("Select Title, Director, Description From Movies WHERE CategoryId = @CategoryId");
            cmd.Parameters.AddWithValue("CategoryId", catId);
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Movie mc = new Movie(reader["Title"].ToString(),
                                     reader["Director"].ToString(),
                                     reader["Description"].ToString());

                movieCategories.Add(mc);
            }
            return movieCategories;
        }















        public string Welcome(string userName)
        {
            return string.Format("Hello {0}, welcome to the world of Web Services!", userName);
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public Equation GenerateEquation()
        {
            Random r = new Random();
            int a = r.Next(200);
            int b = r.Next(200);

            int op = r.Next(3);
            string s = "";

            switch (op)
            {
                case (0):
                    s = "add";
                    break;
                case (1):
                    s = "subtract";
                    break;
                case (2):
                    s = "multiply";
                    break;
            }
            Equation e = new Equation(a, b, s);
            return e;
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
