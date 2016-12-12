using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab01
{
    public partial class MeetingSchedular : System.Web.UI.Page
    {
        String[,] schedule;
        FileStream schedIO;
        BinaryFormatter schedObjIO;

        protected void Page_Load(object sender, EventArgs e)
        {
            schedule = (string[,])Session["schedule"];
            if(schedule == null)
            {
                if (File.Exists(MapPath("toDoList\\toDoList.bin")))
                {
                    schedIO = new FileStream(MapPath("toDoList\\toDoList.bin"), FileMode.Open);
                    schedObjIO = new BinaryFormatter();
                    schedule = (string[,])schedObjIO.Deserialize(schedIO);
                    schedIO.Close();
                }
                else
                {
                    schedule = new string[12, 31];                    
                }
                Session["schedule"] = schedule;
            }
        }     

        protected void Save_Click(object sender, EventArgs e)
        {
            int x = calMeetings.SelectedDate.Month;
            int y = calMeetings.SelectedDate.Day;
            schedule[x, y] = txtMessage.Text;
            Session["schedule"] = schedule;

            schedIO = new FileStream(MapPath("toDoList\\toDoList.bin"), FileMode.Create);
            schedObjIO = new BinaryFormatter();
            schedObjIO.Serialize(schedIO, schedule);

            schedIO.Close();


        }

        protected void calMeetings_onSelectionChanged(object sender, EventArgs e)
        {
            int x = calMeetings.SelectedDate.Month;
            int y = calMeetings.SelectedDate.Day;
            txtMessage.Text = schedule[x, y];
            Session["schedule"] = schedule;
        }


        protected void calMeetings_DayRender(object sender, DayRenderEventArgs e)
        {            
            int x = calMeetings.SelectedDate.Month;
            int y = calMeetings.SelectedDate.Day;
          
            if(schedule[x,y] != null && schedule[x, y].Length > 0)
            {
                TableCell c;
                c = e.Cell;
                c.BackColor = Color.FromName("Green");

            }

        }
    }
}