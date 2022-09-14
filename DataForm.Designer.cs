
namespace Astronomy_Calendar_of_Celestial_Events
{
    partial class DataForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblCalander = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.optCelestrial = new System.Windows.Forms.RadioButton();
            this.optRocket = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthCalendar.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCalendar.Location = new System.Drawing.Point(360, 372);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.TrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // lblCalander
            // 
            this.lblCalander.AutoSize = true;
            this.lblCalander.BackColor = System.Drawing.Color.Transparent;
            this.lblCalander.Font = new System.Drawing.Font("STXihei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalander.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCalander.Location = new System.Drawing.Point(360, 342);
            this.lblCalander.Name = "lblCalander";
            this.lblCalander.Size = new System.Drawing.Size(59, 21);
            this.lblCalander.TabIndex = 7;
            this.lblCalander.Text = "Date";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGo.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGo.Location = new System.Drawing.Point(810, 546);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(94, 29);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(360, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 27);
            this.txtName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("STXihei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(360, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 21);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(360, 136);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(262, 28);
            this.cboLocation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("STXihei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(360, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Location";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHelp.Location = new System.Drawing.Point(574, 352);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(48, 20);
            this.lblHelp.TabIndex = 13;
            this.lblHelp.Text = "Help?";
            this.lblHelp.MouseLeave += new System.EventHandler(this.lblHelp_MouseLeave);
            this.lblHelp.MouseHover += new System.EventHandler(this.lblHelp_MouseHover);
            // 
            // optCelestrial
            // 
            this.optCelestrial.AutoSize = true;
            this.optCelestrial.Location = new System.Drawing.Point(12, 64);
            this.optCelestrial.Name = "optCelestrial";
            this.optCelestrial.Size = new System.Drawing.Size(179, 25);
            this.optCelestrial.TabIndex = 15;
            this.optCelestrial.TabStop = true;
            this.optCelestrial.Text = "Celestrial Event";
            this.optCelestrial.UseVisualStyleBackColor = true;
            this.optCelestrial.CheckedChanged += new System.EventHandler(this.optCelestrial_CheckedChanged);
            // 
            // optRocket
            // 
            this.optRocket.AutoSize = true;
            this.optRocket.Location = new System.Drawing.Point(12, 34);
            this.optRocket.Name = "optRocket";
            this.optRocket.Size = new System.Drawing.Size(176, 25);
            this.optRocket.TabIndex = 16;
            this.optRocket.TabStop = true;
            this.optRocket.Text = "Rocket Launch";
            this.optRocket.UseVisualStyleBackColor = true;
            this.optRocket.CheckedChanged += new System.EventHandler(this.optRocket_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.optRocket);
            this.groupBox1.Controls.Add(this.optCelestrial);
            this.groupBox1.Font = new System.Drawing.Font("STXihei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(360, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 125);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Type";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Astronomy_Calendar_of_Celestial_Events.Properties.Resources.back__10_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblCalander);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.monthCalendar);
            this.MaximizeBox = false;
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lblCalander;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.RadioButton optCelestrial;
        private System.Windows.Forms.RadioButton optRocket;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

