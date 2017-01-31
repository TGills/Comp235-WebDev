using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test2Exercise : System.Web.UI.Page
{
    
    List<Movie> movie;
    protected void Page_Load(object sender, EventArgs e)
    {
        Service1Client S1C = new Service1Client();

        if (!Page.IsPostBack)
        {
            ddlMovieCats.DataValueField = "Id";
            ddlMovieCats.DataTextField = "Name";

            ddlMovieCats.DataSource = S1C.getAllMovieCategories();
            ddlMovieCats.DataBind();
        }
    }

    protected void ddlMovieCats_SelectedIndexChanged(object sender, EventArgs e)
    {
        Service1Client ws = new Service1Client();
        DataList1.DataSource = ws.getAllMoviesByCategory(Convert.ToInt32(ddlMovieCats.SelectedValue));
        DataList1.DataBind();
    }
}