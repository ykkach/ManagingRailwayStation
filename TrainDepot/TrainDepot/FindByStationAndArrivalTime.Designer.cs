﻿namespace TrainDepot
{
    partial class FindByStationAndArrivalTime
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
            this.submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.stationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.submit.Cursor = System.Windows.Forms.Cursors.Default;
            this.submit.Location = new System.Drawing.Point(155, 208);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(253, 68);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(121, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "to get information about trains matched";
            // 
            // time
            // 
            this.time.CustomFormat = "HH:mm";
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time.Location = new System.Drawing.Point(266, 151);
            this.time.Name = "time";
            this.time.ShowUpDown = true;
            this.time.Size = new System.Drawing.Size(151, 26);
            this.time.TabIndex = 24;
            this.time.Value = new System.DateTime(2020, 12, 9, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(141, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Station name:";
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(266, 118);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(151, 26);
            this.stationName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter station name and arrival time in case you want";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(141, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Time of arrival:";
            // 
            // FindByStationAndArrivalTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(558, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stationName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submit);
            this.Name = "FindByStationAndArrivalTime";
            this.Text = "Find by station and time of arrival";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}