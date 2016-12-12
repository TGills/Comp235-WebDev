using MovieLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudyGuide2 : System.Web.UI.Page
{
    protected void Page_PreRender(object sender, EventArgs e)
    {
        MovieUtilities mu = new MovieUtilities();
        Repeater1.DataSource = mu.SelectAll();
        Repeater1.DataBind();

        string query;
        MovieData md = new MovieData();
        int id;
        try
        {
            if (Request.QueryString["Id"].ToString() != null)
            {
                query = Request.QueryString["Id"].ToString();
                id = Convert.ToInt32(query);
                GridView1.DataSource = md.getMoviesByID(id);
                GridView1.DataBind();
            }
            else
            {
                id = 1;
                GridView1.DataSource = md.getMoviesByID(id);
                GridView1.DataBind();
            }
        }
        catch{}






        //string query = Request.QueryString["id"].ToString();

        //int id = Convert.ToInt32(query);
        
        //MovieData md = new MovieData();
      
        //GridView1.DataSource = md.getMoviesByID(id);

        //GridView1.DataBind();

    }
}