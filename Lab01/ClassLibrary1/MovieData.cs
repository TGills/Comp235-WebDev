using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;



namespace MovieLibrary
{
    public class MovieData
    {
        public string connectionString;
        public MovieData()
        {
            connectionString = Connections.ConnectionString();
        }
        public List<Movie> getMovies()
        {
            List<Movie> movies = new List<Movie>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Connections.ConnectionString();

            SqlCommand cmd =
                new SqlCommand("Select Id, Title, Director, Description From Movies");

            cmd.Connection = con;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                movies.Add(new Movie(Convert.ToInt32(reader["id"]),
                        reader["title"].ToString(),
                        reader["director"].ToString(),
                        reader["description"].ToString()));
            }

            con.Close();
            return movies;
        }

        public SqlDataReader getMoviesByID(int selectMovie)
        {
            SqlConnection con = new SqlConnection(Connections.ConnectionString());           
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "Select * From Movies Where Id=@Id";
            cmd.Parameters.AddWithValue("Id", selectMovie);
            // SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);          
            return reader;
        }

        public void MovieUpdate(Movie MovieToUpdate)
        {
            SqlConnection con = new SqlConnection(Connections.ConnectionString());
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "UPDATE Movies SET Title=@Title, Director=@Director, Id=@Id, Description=@Description";
            cmd.Parameters.AddWithValue("@Title", MovieToUpdate.Title);
            cmd.Parameters.AddWithValue("@Director", MovieToUpdate.Director);
            cmd.Parameters.AddWithValue("@Id", MovieToUpdate.Id);
            cmd.Parameters.AddWithValue("@Description", MovieToUpdate.Description);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<Movie> getMovieCategories()
        {
            List<Movie> movies = new List<Movie>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            SqlCommand cmd =
                new SqlCommand("Select Id, Name From MovieCategory");
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                movies.Add(new Movie(
                        Convert.ToInt32(reader["id"].ToString()),
                        reader["title"].ToString(),
                        reader["director"].ToString(),
                        reader["description"].ToString()));
            }
            con.Close();
            return movies;
        }
        public SqlDataReader getMoviesBycatID(int catID)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            SqlCommand cmd =
                new SqlCommand("Select Id, Title, Director, Description From Movies Where CategoryId=@catID");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("catID", catID);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        public SqlDataReader getMoviesByDirector(string director)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            SqlCommand cmd =
                new SqlCommand("Select * From Movies Where Director=@director");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("director", director);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        public SqlDataReader getMoviesByTitle(string Title)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            SqlCommand cmd =
                new SqlCommand("Select * From Movies Where Title=@Title");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("Title", Title);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }      
        public void updateMovie(int id, String title, string director, string description)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            SqlCommand cmd =
                new SqlCommand("Update Movies Set Title=@Title, Director=@Director, Description=@Description Where Id=@Id");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("Title", title);
            cmd.Parameters.AddWithValue("Director", director);
            cmd.Parameters.AddWithValue("Description", description);
            cmd.Parameters.AddWithValue("Id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deleteMovie(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            SqlCommand cmd =
                new SqlCommand("Delete from Movies Where Id=@Id");

            cmd.Connection = con;

            cmd.Parameters.AddWithValue("Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }










    }
}
