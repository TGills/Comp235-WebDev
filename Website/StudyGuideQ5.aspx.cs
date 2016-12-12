using MovieLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudyGuideQ5 : System.Web.UI.Page
{
    int id;
    string name;
    string position;
    protected void Page_PreRender(object sender, EventArgs e)
    {
        MovieUtilities mu = new MovieUtilities();
        MovieData md = new MovieData();
        try
        {
            md.insertMovieCategory(id, name, position);
        }
        catch { }


    }



    protected void Button1_Click(object sender, EventArgs e)
    {        
        id = Convert.ToInt32(tbID.Text);
        name = tbName.Text;
        position = tbPosition.Text;     
    }
}