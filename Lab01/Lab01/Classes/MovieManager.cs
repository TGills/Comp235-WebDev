using Lab01;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for MovieManager
/// </summary>
public class MovieManager
{
    public string connectionString; 
    public MovieManager()
    {
        connectionString = 
            WebConfigurationManager.ConnectionStrings["dbMovies1"].ConnectionString;
    }
    public SqlDataReader getMoviesUsingReader()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = connectionString;
        SqlCommand cmd = 
            new SqlCommand( "Select Id, Title, Director, Description From Movies");
        cmd.Connection = con;
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        return reader;
    }
    public List<Movies> getMovies()
    {
        List<Movies> movies = new List<Movies>();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = connectionString;
        SqlCommand cmd =
            new SqlCommand("Select Id, Title, Director, Description From Movies");
        cmd.Connection = con;
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            movies.Add(new Movies(
                Convert.ToInt32(reader["id"].ToString()),
                reader["title"].ToString(),
                reader["director"].ToString(),
                reader["description"].ToString()));
        }
        con.Close();
        return movies;
    }
    public List<MovieCategory> getMovieCategories()
    {
        List<MovieCategory> movies = new List<MovieCategory>();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = connectionString;
        SqlCommand cmd =
            new SqlCommand("Select Id, Name From MovieCategory");
        cmd.Connection = con;
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            movies.Add(new MovieCategory(
                Convert.ToInt32(reader["id"].ToString()),
                reader["name"].ToString()));
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