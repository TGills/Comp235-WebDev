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
        conString = WebConfigurationManager.ConnectionStrings["dbWeatherData"].ConnectionString;
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