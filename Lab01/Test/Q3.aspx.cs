using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Q3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAddEmployee_Click(object sender, EventArgs e)
    {
        //Works if you take the web address and hit enter on it...
        //Enable postback somehow..?
        int JobCode = Convert.ToInt32(DropDownList1.Text);
        //int jCode = Convert.ToInt32(txtJobCode.Text);
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;

        employeeManager em = new employeeManager();
        em.insertEmployee(JobCode, firstName, lastName);
    }
}