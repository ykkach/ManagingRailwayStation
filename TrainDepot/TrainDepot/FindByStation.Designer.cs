﻿namespace TrainDepot
{
    partial class FindByStation
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
            this.stationName = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(242, 143);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(151, 26);
            this.stationName.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.submit.Cursor = System.Windows.Forms.Cursors.Default;
            this.submit.Location = new System.Drawing.Point(150, 204);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(218, 69);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter station name in case you want";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "to get number of trains with such station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Station name:";
            // 
            // FindByStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(522, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.stationName);
            this.Name = "FindByStation";
            this.Opacity = 0.95D;
            this.Text = "Number of trains with station";
            this.Load += new System.EventHandler(this.FindByStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stationName;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}