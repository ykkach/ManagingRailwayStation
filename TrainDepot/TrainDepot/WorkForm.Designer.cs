namespace TrainDepot
{
    partial class WorkForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortBySpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNumberOfSpecificTrainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findTrainByTimeOfArrivalToTheStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findTrainByTimeOfDepartureFromTheStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupByLastStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.logLine = new System.Windows.Forms.Label();
            this.trainDataTable = new System.Windows.Forms.DataGridView();
            this.finalStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1748, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.sortBySpeedToolStripMenuItem,
            this.sortByStationToolStripMenuItem,
            this.findNumberOfSpecificTrainsToolStripMenuItem,
            this.findTrainByTimeOfArrivalToTheStationToolStripMenuItem,
            this.findTrainByTimeOfDepartureFromTheStationToolStripMenuItem,
            this.groupByLastStationToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(490, 34);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // sortBySpeedToolStripMenuItem
            // 
            this.sortBySpeedToolStripMenuItem.Name = "sortBySpeedToolStripMenuItem";
            this.sortBySpeedToolStripMenuItem.Size = new System.Drawing.Size(490, 34);
            this.sortBySpeedToolStripMenuItem.Text = "Sort by speed";
            this.sortBySpeedToolStripMenuItem.Click += new System.EventHandler(this.sortBySpeedToolStripMenuItem_Click);
            // 
            // sortByStationToolStripMenuItem
            // 
            this.sortByStationToolStripMenuItem.Name = "sortByStationToolStripMenuItem";
            this.sortByStationToolStripMenuItem.Size = new System.Drawing.Size(490, 34);
            this.sortByStationToolStripMenuItem.Text = "Sort by initial station";
            this.sortByStationToolStripMenuItem.Click += new System.EventHandler(this.sortByStationToolStripMenuItem_Click);
            // 
            // findNumberOfSpecificTrainsToolStripMenuItem
            // 
            this.findNumberOfSpecificTrainsToolStripMenuItem.Name = "findNumberOfSpecificTrainsToolStripMenuItem";
            this.findNumberOfSpecificTrainsToolStripMenuItem.Size = new System.Drawing.Size(490, 34);
            this.findNumberOfSpecificTrainsToolStripMenuItem.Text = "Get number of trains with station";
            this.findNumberOfSpecificTrainsToolStripMenuItem.Click += new System.EventHandler(this.findNumberOfSpecificTrainsToolStripMenuItem_Click);
            // 
            // findTrainByTimeOfArrivalToTheStationToolStripMenuItem
            // 
            this.findTrainByTimeOfArrivalToTheStationToolStripMenuItem.Name = "findTrainByTimeOfArrivalToTheStationToolStripMenuItem";
            this.findTrainByTimeOfArrivalToTheStationToolStripMenuItem.Size = new System.Drawing.Size(490, 34);
            this.findTrainByTimeOfArrivalToTheStationToolStripMenuItem.Text = "Find train by time of arrival to the station";
            this.findTrainByTimeOfArrivalToTheStationToolStripMenuItem.Click += new System.EventHandler(this.findTrainByTimeOfArrivalToTheStationToolStripMenuItem_Click);
            // 
            // findTrainByTimeOfDepartureFromTheStationToolStripMenuItem
            // 
            this.findTrainByTimeOfDepartureFromTheStationToolStripMenuItem.Name = "findTrainByTimeOfDepartureFromTheStationToolStripMenuItem";
            this.findTrainByTimeOfDepartureFromTheStationToolStripMenuItem.Size = new System.Drawing.Size(490, 34);
            this.findTrainByTimeOfDepartureFromTheStationToolStripMenuItem.Text = "Find train by time of departure from the station";
            this.findTrainByTimeOfDepartureFromTheStationToolStripMenuItem.Click += new System.EventHandler(this.findTrainByTimeOfDepartureFromTheStationToolStripMenuItem_Click);
            // 
            // groupByLastStationToolStripMenuItem
            // 
            this.groupByLastStationToolStripMenuItem.Name = "groupByLastStationToolStripMenuItem";
            this.groupByLastStationToolStripMenuItem.Size = new System.Drawing.Size(490, 34);
            this.groupByLastStationToolStripMenuItem.Text = "Group by last station";
            this.groupByLastStationToolStripMenuItem.Click += new System.EventHandler(this.groupByLastStationToolStripMenuItem_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.bindingNavigator1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 33);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(42, 690);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(37, 40);
            this.toolStripButton2.Text = "New";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(37, 40);
            this.toolStripButton3.Text = "Open";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(37, 40);
            this.toolStripButton4.Text = "Save";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(37, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 40);
            this.toolStripButton1.Text = "Add new";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // logLine
            // 
            this.logLine.AutoSize = true;
            this.logLine.Location = new System.Drawing.Point(59, 736);
            this.logLine.Name = "logLine";
            this.logLine.Size = new System.Drawing.Size(0, 20);
            this.logLine.TabIndex = 5;
            // 
            // trainDataTable
            // 
            this.trainDataTable.AllowUserToAddRows = false;
            this.trainDataTable.AllowUserToDeleteRows = false;
            this.trainDataTable.AllowUserToResizeRows = false;
            this.trainDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trainDataTable.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trainDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.trainDataTable.ColumnHeadersHeight = 60;
            this.trainDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.initStation,
            this.km1,
            this.station,
            this.km2,
            this.station3,
            this.km3,
            this.station4,
            this.km4,
            this.finalStation});
            this.trainDataTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trainDataTable.Location = new System.Drawing.Point(129, 92);
            this.trainDataTable.Name = "trainDataTable";
            this.trainDataTable.ReadOnly = true;
            this.trainDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trainDataTable.RowHeadersVisible = false;
            this.trainDataTable.RowHeadersWidth = 62;
            this.trainDataTable.RowTemplate.Height = 28;
            this.trainDataTable.Size = new System.Drawing.Size(1530, 576);
            this.trainDataTable.TabIndex = 4;
            this.trainDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainDataTable_CellContentClick);
            // 
            // finalStation
            // 
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.finalStation.DefaultCellStyle = dataGridViewCellStyle44;
            this.finalStation.HeaderText = "       Final station";
            this.finalStation.MinimumWidth = 8;
            this.finalStation.Name = "finalStation";
            this.finalStation.ReadOnly = true;
            // 
            // km4
            // 
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.km4.DefaultCellStyle = dataGridViewCellStyle43;
            this.km4.HeaderText = "    -";
            this.km4.MinimumWidth = 8;
            this.km4.Name = "km4";
            this.km4.ReadOnly = true;
            // 
            // station4
            // 
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.station4.DefaultCellStyle = dataGridViewCellStyle42;
            this.station4.HeaderText = "              Station";
            this.station4.MinimumWidth = 8;
            this.station4.Name = "station4";
            this.station4.ReadOnly = true;
            // 
            // km3
            // 
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.km3.DefaultCellStyle = dataGridViewCellStyle41;
            this.km3.HeaderText = "    -";
            this.km3.MinimumWidth = 8;
            this.km3.Name = "km3";
            this.km3.ReadOnly = true;
            // 
            // station3
            // 
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.station3.DefaultCellStyle = dataGridViewCellStyle40;
            this.station3.HeaderText = "              Station";
            this.station3.MinimumWidth = 8;
            this.station3.Name = "station3";
            this.station3.ReadOnly = true;
            // 
            // km2
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.km2.DefaultCellStyle = dataGridViewCellStyle39;
            this.km2.HeaderText = "    -";
            this.km2.MinimumWidth = 8;
            this.km2.Name = "km2";
            this.km2.ReadOnly = true;
            // 
            // station
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.station.DefaultCellStyle = dataGridViewCellStyle38;
            this.station.HeaderText = "              Station";
            this.station.MinimumWidth = 8;
            this.station.Name = "station";
            this.station.ReadOnly = true;
            // 
            // km1
            // 
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.km1.DefaultCellStyle = dataGridViewCellStyle37;
            this.km1.HeaderText = "    -";
            this.km1.MinimumWidth = 8;
            this.km1.Name = "km1";
            this.km1.ReadOnly = true;
            // 
            // initStation
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.initStation.DefaultCellStyle = dataGridViewCellStyle36;
            this.initStation.HeaderText = "       Initial station";
            this.initStation.MinimumWidth = 8;
            this.initStation.Name = "initStation";
            this.initStation.ReadOnly = true;
            // 
            // number
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number.DefaultCellStyle = dataGridViewCellStyle35;
            this.number.HeaderText = " Train number";
            this.number.MinimumWidth = 8;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1748, 723);
            this.Controls.Add(this.logLine);
            this.Controls.Add(this.trainDataTable);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1770, 779);
            this.MinimumSize = new System.Drawing.Size(1770, 779);
            this.Name = "WorkForm";
            this.Opacity = 0.95D;
            this.Text = "Train Depot";
            this.Load += new System.EventHandler(this.WorkForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label logLine;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortBySpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNumberOfSpecificTrainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findTrainByTimeOfArrivalToTheStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findTrainByTimeOfDepartureFromTheStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupByLastStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridView trainDataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn initStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn km1;
        private System.Windows.Forms.DataGridViewTextBoxColumn station;
        private System.Windows.Forms.DataGridViewTextBoxColumn km2;
        private System.Windows.Forms.DataGridViewTextBoxColumn station3;
        private System.Windows.Forms.DataGridViewTextBoxColumn km3;
        private System.Windows.Forms.DataGridViewTextBoxColumn station4;
        private System.Windows.Forms.DataGridViewTextBoxColumn km4;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalStation;
    }
}