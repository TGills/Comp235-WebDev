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

        //string query = Request.QueryString["Title"].ToString();


        


    }
}