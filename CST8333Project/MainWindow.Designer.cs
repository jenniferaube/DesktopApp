namespace $safeprojectname$
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.findText = new System.Windows.Forms.ToolStripTextBox();
            this.columnDropDown = new System.Windows.Forms.ToolStripComboBox();
            this.findBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dropDown = new System.Windows.Forms.ToolStripComboBox();
            this.columnBtn = new System.Windows.Forms.ToolStripButton();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bar = new System.Windows.Forms.ToolStripProgressBar();
            this.sourceLink = new System.Windows.Forms.LinkLabel();
            this.licenseLink = new System.Windows.Forms.LinkLabel();
            this.loadBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.findText,
            this.columnDropDown,
            this.findBtn,
            this.toolStripSeparator1,
            this.statsBtn,
            this.toolStripSeparator2,
            this.showAllBtn,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.dropDown,
            this.columnBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1076, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 27);
            this.toolStripLabel1.Text = "Find: ";
            // 
            // findText
            // 
            this.findText.Name = "findText";
            this.findText.Size = new System.Drawing.Size(100, 30);
            // 
            // columnDropDown
            // 
            this.columnDropDown.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.columnDropDown.Items.AddRange(new object[] {
            "Ref_Date",
            "Geo",
            "Commod",
            "Vector",
            "Coordinate",
            "Value"});
            this.columnDropDown.Name = "columnDropDown";
            this.columnDropDown.Size = new System.Drawing.Size(121, 30);
            this.columnDropDown.Text = "Select column";
            // 
            // findBtn
            // 
            this.findBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findBtn.Image = ((System.Drawing.Image)(resources.GetObject("findBtn.Image")));
            this.findBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(24, 27);
            this.findBtn.Text = "toolStripButton1";
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // statsBtn
            // 
            this.statsBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsBtn.Image = ((System.Drawing.Image)(resources.GetObject("statsBtn.Image")));
            this.statsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(106, 27);
            this.statsBtn.Text = "Statistics";
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // showAllBtn
            // 
            this.showAllBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showAllBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("showAllBtn.Image")));
            this.showAllBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(85, 27);
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(103, 27);
            this.toolStripLabel2.Text = "Show only: ";
            // 
            // dropDown
            // 
            this.dropDown.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dropDown.Items.AddRange(new object[] {
            "Ref_Date",
            "Geo",
            "Commod",
            "Vector",
            "Coordinate",
            "Value"});
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(121, 30);
            this.dropDown.Text = "Select column";
            // 
            // columnBtn
            // 
            this.columnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.columnBtn.Image = ((System.Drawing.Image)(resources.GetObject("columnBtn.Image")));
            this.columnBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.columnBtn.Name = "columnBtn";
            this.columnBtn.Size = new System.Drawing.Size(24, 27);
            this.columnBtn.Text = "toolStripButton1";
            this.columnBtn.Click += new System.EventHandler(this.columnBtn_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(13, 63);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(1048, 402);
            this.gridView.TabIndex = 2;
            this.gridView.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabel,
            this.toolStripSeparator4,
            this.bar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 501);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1076, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(93, 22);
            this.tsLabel.Text = "Opening File";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bar
            // 
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(100, 22);
            this.bar.Visible = false;
            // 
            // sourceLink
            // 
            this.sourceLink.AutoSize = true;
            this.sourceLink.Location = new System.Drawing.Point(952, 501);
            this.sourceLink.Name = "sourceLink";
            this.sourceLink.Size = new System.Drawing.Size(124, 17);
            this.sourceLink.TabIndex = 4;
            this.sourceLink.TabStop = true;
            this.sourceLink.Text = "Source of DataSet";
            this.sourceLink.Visible = false;
            this.sourceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourceLink_LinkClicked);
            // 
            // licenseLink
            // 
            this.licenseLink.AutoSize = true;
            this.licenseLink.Location = new System.Drawing.Point(889, 500);
            this.licenseLink.Name = "licenseLink";
            this.licenseLink.Size = new System.Drawing.Size(57, 17);
            this.licenseLink.TabIndex = 5;
            this.licenseLink.TabStop = true;
            this.licenseLink.Text = "License";
            this.licenseLink.Visible = false;
            this.licenseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenseLink_LinkClicked);
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.Location = new System.Drawing.Point(470, 211);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(101, 42);
            this.loadBtn.TabIndex = 6;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1076, 526);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.licenseLink);
            this.Controls.Add(this.sourceLink);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainWindow";
            this.Text = "Main Window By Jennifer Aube";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox findText;
        private System.Windows.Forms.ToolStripButton findBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton statsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton showAllBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox dropDown;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tsLabel;
        private System.Windows.Forms.ToolStripButton columnBtn;
        private System.Windows.Forms.ToolStripComboBox columnDropDown;
        private System.Windows.Forms.LinkLabel sourceLink;
        private System.Windows.Forms.LinkLabel licenseLink;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripProgressBar bar;
    }
}

