using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ajax : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblLoadTime.Text = DateTime.Now.ToString();
    }

    protected void lnkPartialSubmit_Click(object sender, EventArgs e)
    {
        lblParitalLoadTime.Text = DateTime.Now.ToString();
    }

    protected void lnkSubmit_Click(object sender, EventArgs e)
    {

    }
}