﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Astronomy_Calendar_of_Celestial_Events
{
    public partial class Loading : Form
    {
        DataForm nextForm = new DataForm();

        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            nextForm.Show();           

        }
    }
}
