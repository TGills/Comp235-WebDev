﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class MovieData
    {
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











    }
}
