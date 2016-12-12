﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_PreRender(object sender, EventArgs e)
    {
        MovieUtilities mu = new MovieUtilities();
        GridView1.DataSource = mu.SelectAll();
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridView1.DataBind();
    }    
    protected void Gridview1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GridView1.DataBind();
    }

    protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {
        int id = Convert.ToInt32(e.Keys["Id"].ToString());
        string title = e.NewValues["Title"].ToString();
        string director = e.NewValues["Director"].ToString();
        string description = e.NewValues["Description"].ToString();
        MovieUtilities mu = new MovieUtilities();
        mu.UpdateMovie(id, title, director, description);       
        GridView1.EditIndex = -1;
        GridView1.DataBind();
    }
}