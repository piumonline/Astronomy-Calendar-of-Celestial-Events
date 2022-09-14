using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Astronomy_Calendar_of_Celestial_Events
{
    public partial class EventForm : Form
    {
        DataForm mainForm = new DataForm(); //create an object from Form1
        private String date, location; 
        private bool rocketEvent, celestrialEvent; //event holder
        private String name;

        //constructor
        public EventForm(String date, bool rocketEvent, bool celestrialEvent, String name, String location)
        {
            InitializeComponent();
            //initialize the variables
            this.date = date;
            this.rocketEvent = rocketEvent;
            this.celestrialEvent = celestrialEvent;
            this.name = name;
            this.location = location;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            pictureBox.Hide(); pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide();
            pictureBox6.Hide(); pictureBox7.Hide(); pictureBox8.Hide(); pictureBox9.Hide(); pictureBox5.Hide();

            //rockets events of the year
            if (rocketEvent == true)
            {
                switch (date)
                {
                    case ("1/7/2022"):
                        pictureBox.Show();
                        lblNameDate.Text = name + "  you have rocket launch event to watch on " + date + " at " + location;
                        pictureBox.Image = Properties.Resources.Launch__1_;                        

                        break;

                    case ("1/13/2022"):
                        pictureBox.Show(); pictureBox1.Show();
                        lblNameDate.Text = name + "  you have rocket launch event to watch on " + date + " at " + location;
                        pictureBox.Image = Properties.Resources.Launch__15_;
                        pictureBox1.Image = Properties.Resources.Launch__14_;

                        break;

                    case ("1/20/2022"):
                        pictureBox.Show();
                        lblNameDate.Text = name + "  you have rocket launch event to watch on " + date + " at " + location;
                        pictureBox.Image = Properties.Resources.Launch__13_;

                        break;

                    case ("1/21/2022"):
                        pictureBox.Show();
                        lblNameDate.Text = name + "  you have rocket launch event to watch on " + date + " at " + location;
                        pictureBox.Image = Properties.Resources.Launch__12_;

                        break;

                    case ("1/31/2022"):
                        lblNameDate.Text = name + "  you have rocket launch event to watch on " + date + " at " + location;
                        pictureBox.Show();  pictureBox.Image = Properties.Resources.Launch__11_;
                        pictureBox1.Show();  pictureBox1.Image = Properties.Resources.Launch__10_;
                        pictureBox2.Show();  pictureBox2.Image = Properties.Resources.Launch__9_;
                        pictureBox3.Show();  pictureBox3.Image = Properties.Resources.Launch__8_;
                        pictureBox4.Show();  pictureBox4.Image = Properties.Resources.Launch__7_;
                        pictureBox5.Show();  pictureBox5.Image = Properties.Resources.Launch__6_;
                        pictureBox6.Show();  pictureBox6.Image = Properties.Resources.Launch__5_;
                        pictureBox7.Show();  pictureBox7.Image = Properties.Resources.Launch__4_;
                        pictureBox8.Show();  pictureBox8.Image = Properties.Resources.Launch__3_;
                        pictureBox9.Show();  pictureBox9.Image = Properties.Resources.Launch__2_;
                        
                        break;

                    default:
                        lblNameDate.Text = name + " you have no rocket launch event to watch on " + date + " at " + location;

                        break;
                }              
            }

            //celestrial events of the year
            if (celestrialEvent == true)
            {
                switch (date)
                {
                    case ("1/2/2022"):
                        pictureBox.Show();
                        lblNameDate.Text = name + " you have rocket launch event to watch on " + date + " at " + location;
                        pictureBox.Image = Properties.Resources.celestrial__4_;
                        
                        break;

                    case ("1/3/2022"):
                        pictureBox.Show();
                        lblNameDate.Text = name + " you have rocket launch event to watch on " + date + " at " + location;
                        pictureBox.Image = Properties.Resources.celestrial__3_;
                        
                        break;

                    case ("1/4/2022"):
                        pictureBox.Show();
                        lblNameDate.Text = name + " you have rocket launch event to watch on " + date + " at " + location;
                        pictureBox.Image = Properties.Resources.celestrial__3_;
                        
                        break;

                    case ("1/7/2022"):
                        pictureBox.Show();
                        lblNameDate.Text = name + " you have rocket launch event to watch on " + date + " at " + location;
                        pictureBox.Image = Properties.Resources.celestrial__2_;
                        
                        break;

                    case ("1/17/2022"):
                        pictureBox.Show();
                        lblNameDate.Text = name + " you have rocket launch event to watch on " + date + " at " + location;
                        pictureBox.Image = Properties.Resources.celestrial__1_;
                        
                        break;

                    default:
                        lblNameDate.Text = name + " sorry no celestrial event to watch on " + date + " at " + location;

                        break;
                }
            }
        }
        //Go to previous form
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.helpprovider?view=windowsdesktop-6.0");
        }

    }
}
