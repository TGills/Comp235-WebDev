using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WeatherReport
/// </summary>
public class WeatherReport
{
    public float Lat { get; set; }
    public float Lon { get; set; }
    public float Facing { get; set; }
    public DateTime DateSubmitted { get; set; } 
    public int Id { get; set; }



    public WeatherReport() { }
    
    public WeatherReport(int id, float lat, float lon, float facing, DateTime dateSubmitted)
    {
        Id = id;
        Lat = lat;
        Lon = lon;
        Facing = facing;
        DateSubmitted = dateSubmitted;
        
    }

}