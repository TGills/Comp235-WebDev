using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class ReviewExercise2 : System.Web.UI.Page
    {
        Person[] people;
        int current;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                current = 0;
            }            
            people = new Person[5];

            people[0] = new Person("Bob", "Smith", "123-4567", new Address("200 2nd Ave", "Minneapolis", "MN", "55416"));
            people[1] = new Person("Bill", "Brooks", "122-1211", new Address("14 John St.", "St. Petersburg", "FL", "11358"));
            people[2] = new Person("Gus", "Fraiser", "123-4447", new Address("20 29th St.", "Chicago", "IL", "60612"));
            people[3] = new Person("Tom", "Jones", "123-5555", new Address("701 Pots Rd.", "Holtsville", "NY", "06543"));
            people[4] = new Person("Sue", "Shard", "123-7894", new Address("701 Pots Rd.", "Holtsville", "NY", "06543"));

            if (Session["current"] != null)
            {
                current = (int)Session["current"];
            }
            Display(current);
        }
        public string Phone
        {
            get { return txtPhoneNumber.Text; }
            set
            {
                if (value != "")
                    txtPhoneNumber.Text = value;
                else
                    txtPhoneNumber.Text = "Not Provided";
            }
        }        
        public void Display(int current)
        {
            txtFirstName.Text = people[current].FirstName;
            txtLastName.Text = people[current].LastName;
            txtPhoneNumber.Text = people[current].PhoneNumber;
        }
        protected void lbPrevious_Click(object sender, EventArgs e)
        {
            current--;                       
            if(current == -1)
            {
                current = people.GetLowerBound(0); 
            }
            Display(current);
            Session["current"] = current;
            
        }
        protected void lbNext_Click(object sender, EventArgs e)
        {
            current++;            
            if(current > people.GetUpperBound(0))
            {
                current = 0;
            }
            Display(current);
            Session["current"] = current;

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {




        }
    }
}