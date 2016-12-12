using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    

    public partial class Calendar : System.Web.UI.Page
    {
        Random r = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void calHoroscope_DayRender(object sender, DayRenderEventArgs e)
        {
            TableCell c;
            string horoscope = "";
            c = e.Cell;

            int num = r.Next(4);
            switch (num)
            {
                case 0:
                    horoscope = "Good Things Will Happen Today";
                    c.BackColor = Color.FromName("Green");
                    break;
                case 1:
                    horoscope = "You’re doomed.  Hide in bed today";
                    c.BackColor = Color.FromName("Red");
                    break;
                case 2:
                    horoscope = "Something Unexpected will happen";
                    c.BackColor = Color.FromName("Yellow");
                    break;
                case 3:
                    horoscope = "Look before you leap";
                    c.BackColor = Color.FromName("Violet");
                    break;
            }
            c.Controls.Add(new LiteralControl("<p>"));
            c.Controls.Add(new LiteralControl(horoscope));




        }
    }
}