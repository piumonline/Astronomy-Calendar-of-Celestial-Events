
namespace Astronomy_Calendar_of_Celestial_Events
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGo = new System.Windows.Forms.Button();
            this.lblTitleHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGo.Location = new System.Drawing.Point(470, 468);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(138, 50);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Let\'s Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitleHead
            // 
            this.lblTitleHead.AutoSize = true;
            this.lblTitleHead.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleHead.Font = new System.Drawing.Font("STXihei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleHead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleHead.Location = new System.Drawing.Point(86, 251);
            this.lblTitleHead.Name = "lblTitleHead";
            this.lblTitleHead.Size = new System.Drawing.Size(888, 46);
            this.lblTitleHead.TabIndex = 1;
            this.lblTitleHead.Text = "Astronomy Calendar  of Celestial Events";
            this.lblTitleHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Astronomy_Calendar_of_Celestial_Events.Properties.Resources.back__8_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 644);
            this.Controls.Add(this.lblTitleHead);
            this.Controls.Add(this.btnGo);
            this.MaximizeBox = false;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomy Calendar of Celestial Events";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblTitleHead;
    }
}