using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WeatherReportViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        WeatherUtilities wu = new WeatherUtilities();
        GridView1.DataSource = wu.getAllReports();
        GridView1.DataBind();
        


    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        float lat = Convert.ToSingle(txtLat.Text);
        float lon = Convert.ToSingle(txtLon.Text);
        float facing = Convert.ToSingle(txtFacing.Text);
        
        WeatherReport wr = 
            new WeatherReport(-1, lat, lon, facing, DateTime.Now);

        WeatherUtilities wu = new WeatherUtilities();
        wu.addWeatherReport(wr);

      

    }
}