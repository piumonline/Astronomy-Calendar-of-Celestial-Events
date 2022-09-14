using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomy_Calendar_of_Celestial_Events
{
    public partial class DataForm : Form
    {
        private String date; //store date
        private bool rocketEvent, celestrialEvent = false; //store option user choosed
       
        public DataForm()//constructor
        {
            InitializeComponent();
            
            // Set the maximum visible date on the calendar to 12/31/2010.
            this.monthCalendar.MaxDate = new System.DateTime(2022, 1, 31, 0, 0, 0, 0);

            // Set the minimum visible date on calendar to 12/31/2010.
            this.monthCalendar.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //add combo box items
            cboLocation.Items.Add("Sri Lanka");
            cboLocation.Items.Add("India");
            cboLocation.Items.Add("USA");
            cboLocation.Items.Add("USR");
            cboLocation.Items.Add("UK");
            cboLocation.Items.Add("Japan");
            cboLocation.Items.Add("Canada");
            cboLocation.Items.Add("New zeland");
            cboLocation.Items.Add("China");
        }

        // Bold Rocket launch events in the calander
        private void optRocket_CheckedChanged(object sender, EventArgs e)
        {
            if (optRocket.Checked) 
            {
                rocketEvent = true;

                // Add dates to BoldedDates array.
                this.monthCalendar.BoldedDates = new System.DateTime[] { new System.DateTime(2022, 1, 7, 0, 0, 0, 0),
                new System.DateTime(2022, 1, 13, 0, 0, 0, 0),
                new System.DateTime(2022, 1, 20, 0, 0, 0, 0),
                new System.DateTime(2022, 1, 21, 0, 0, 0, 0),
                new System.DateTime(2022, 1, 31, 0, 0, 0, 0) };
            }
            else
            {
                //remove bold dates
                monthCalendar.RemoveAllBoldedDates();
                monthCalendar.UpdateBoldedDates();
            }                       
        }

        // Bold Celestrial events in the calander
        private void optCelestrial_CheckedChanged(object sender, EventArgs e)
        {
            if (optCelestrial.Checked)
            {
                celestrialEvent = true;
                // Add dates to BoldedDates array.
                this.monthCalendar.BoldedDates = new System.DateTime[] { new System.DateTime(2022, 1, 2, 0, 0, 0, 0),
                new System.DateTime(2022, 1, 3, 0, 0, 0, 0),
                new System.DateTime(2022, 1, 4, 0, 0, 0, 0),
                new System.DateTime(2022, 1, 7, 0, 0, 0, 0),
                new System.DateTime(2022, 1, 17, 0, 0, 0, 0) };
            }
            else
            {
                //remove bold dates
                monthCalendar.RemoveAllBoldedDates();
                monthCalendar.UpdateBoldedDates();
            }
        }
        
        //load next form
        private void btnGo_Click(object sender, EventArgs e)
        {
            //check any empty feilds available
            if (txtName.Text.Trim() == "" || cboLocation.Text == "" || (optCelestrial.Checked == false && optRocket.Checked ==false ))
            {
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Please enter all feilds "); //warning message box
            }
            else
            {   
                //go to next form
                EventForm eventForm = new EventForm(date, rocketEvent, celestrialEvent, txtName.Text, cboLocation.Text);
                eventForm.Show();
                this.Hide();
            }
        }
        //when moves hover help lable text changes
        private void lblHelp_MouseHover(object sender, EventArgs e)
        {
            lblHelp.Text = "Please double click the bolded date \nyou wanted to see the events in that day";
            lblHelp.BackColor = Color.White;
            lblHelp.ForeColor = Color.Black;
        }

        private void lblHelp_MouseLeave(object sender, EventArgs e)
        {
            lblHelp.BackColor = Color.Transparent;
            lblHelp.ForeColor = Color.AliceBlue;
            lblHelp.Text = "Help?";
        }

        //store selected mm/dd/yyy in to data variable
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            date = monthCalendar.SelectionRange.Start.ToShortDateString();
        }
    }
}
