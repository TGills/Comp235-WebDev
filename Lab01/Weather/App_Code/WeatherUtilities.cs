using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for WeatherUtilities
/// </summary>
public class WeatherUtilities
{
    string conString;

    public WeatherUtilities()
    {
        conString = WebConfigurationManager.ConnectionStrings["WeatherReports1ConnectionString"].ConnectionString;
    }

    public List<WeatherReport> getAllReports()
    {
        List<WeatherReport> reports = new List<WeatherReport>();
        
        SqlConnection con = new SqlConnection();
        con.ConnectionString = conString;
        SqlCommand cmd = new SqlCommand("SELECT * FROM Reports");

        
        con.Open();
        cmd.Connection = con;


        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            WeatherReport wr = new WeatherReport(
                Convert.ToInt32(reader["id"]),
                Convert.ToSingle(reader["Lat"]),
                Convert.ToSingle(reader["Lon"]),
                Convert.ToSingle(reader["Facing"]),
                Convert.ToDateTime(reader["TimeSubmitted"]));
            reports.Add(wr);
        }
        
        con.Close();
        return reports;
    }

    public void addWeatherReport(WeatherReport wr)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = conString;
        SqlCommand cmd = new SqlCommand(
            "Insert Into Reports (lat,lon,timesubmitted,facing) Values(@lat,@lon,@datesubmitted,@facing)"
         );

        cmd.Parameters.AddWithValue("lat", wr.Lat);
        cmd.Parameters.AddWithValue("lon", wr.Lon);
        cmd.Parameters.AddWithValue("facing", wr.Facing);
        cmd.Parameters.AddWithValue("datesubmitted", wr.DateSubmitted);

        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

    }
    




}