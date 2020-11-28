namespace TrainDepot
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OpenNew = new System.Windows.Forms.Button();
            this.OpenFromFile = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "some text here";
            // 
            // OpenNew
            // 
            this.OpenNew.Location = new System.Drawing.Point(271, 139);
            this.OpenNew.Name = "OpenNew";
            this.OpenNew.Size = new System.Drawing.Size(334, 82);
            this.OpenNew.TabIndex = 1;
            this.OpenNew.Text = "New";
            this.OpenNew.UseVisualStyleBackColor = true;
            this.OpenNew.Click += new System.EventHandler(this.OpenNew_Click);
            // 
            // OpenFromFile
            // 
            this.OpenFromFile.Location = new System.Drawing.Point(271, 227);
            this.OpenFromFile.Name = "OpenFromFile";
            this.OpenFromFile.Size = new System.Drawing.Size(334, 82);
            this.OpenFromFile.TabIndex = 2;
            this.OpenFromFile.Text = "Recent";
            this.OpenFromFile.UseVisualStyleBackColor = true;
            this.OpenFromFile.Click += new System.EventHandler(this.OpenFromFile_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(271, 315);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(334, 82);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 586);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OpenFromFile);
            this.Controls.Add(this.OpenNew);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenNew;
        private System.Windows.Forms.Button OpenFromFile;
        private System.Windows.Forms.Button Exit;
    }
}

