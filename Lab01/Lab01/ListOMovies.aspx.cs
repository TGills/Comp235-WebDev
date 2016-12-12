using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class ListOMovies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lnkAdd_Click(object sneder, EventArgs e)
        {
            MovieCatagories m = new Movie;
            m.Title = txtTitle.Text;
            m.Director = txtDirector.Text;
            m.InTheaters = chkNowPlaying.Checked;
            m.Description = txtDescription.Text;

            MovieManager manager = new MovieManager();
            manager.insertMovie(m);
        }
    }
}