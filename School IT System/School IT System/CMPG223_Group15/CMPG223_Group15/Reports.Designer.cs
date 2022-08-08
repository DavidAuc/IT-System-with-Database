namespace CMPG223_Group15
{
    partial class Reports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.pnlState = new System.Windows.Forms.Panel();
            this.cbTotalState = new System.Windows.Forms.CheckBox();
            this.pnlEvents = new System.Windows.Forms.Panel();
            this.cbIncludeTotals = new System.Windows.Forms.CheckBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboboxReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLanguageSwitch = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.pnlState.SuspendLayout();
            this.pnlEvents.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.lbOutput);
            this.panel1.Controls.Add(this.pnlState);
            this.panel1.Controls.Add(this.pnlEvents);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 387);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(155, 34);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export to Text File";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 165);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(155, 34);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(12, 205);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(752, 173);
            this.lbOutput.TabIndex = 5;
            // 
            // pnlState
            // 
            this.pnlState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlState.Controls.Add(this.cbTotalState);
            this.pnlState.Location = new System.Drawing.Point(12, 52);
            this.pnlState.Name = "pnlState";
            this.pnlState.Size = new System.Drawing.Size(752, 107);
            this.pnlState.TabIndex = 4;
            // 
            // cbTotalState
            // 
            this.cbTotalState.AutoSize = true;
            this.cbTotalState.Location = new System.Drawing.Point(37, 16);
            this.cbTotalState.Name = "cbTotalState";
            this.cbTotalState.Size = new System.Drawing.Size(135, 17);
            this.cbTotalState.TabIndex = 5;
            this.cbTotalState.Text = "Include totals in Report";
            this.cbTotalState.UseVisualStyleBackColor = true;
            // 
            // pnlEvents
            // 
            this.pnlEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvents.Controls.Add(this.cbIncludeTotals);
            this.pnlEvents.Controls.Add(this.dtpEnd);
            this.pnlEvents.Controls.Add(this.lblEndDate);
            this.pnlEvents.Controls.Add(this.dtpStart);
            this.pnlEvents.Controls.Add(this.lblStartDate);
            this.pnlEvents.Location = new System.Drawing.Point(12, 52);
            this.pnlEvents.Name = "pnlEvents";
            this.pnlEvents.Size = new System.Drawing.Size(752, 107);
            this.pnlEvents.TabIndex = 1;
            // 
            // cbIncludeTotals
            // 
            this.cbIncludeTotals.AutoSize = true;
            this.cbIncludeTotals.Location = new System.Drawing.Point(37, 78);
            this.cbIncludeTotals.Name = "cbIncludeTotals";
            this.cbIncludeTotals.Size = new System.Drawing.Size(135, 17);
            this.cbIncludeTotals.TabIndex = 5;
            this.cbIncludeTotals.Text = "Include totals in Report";
            this.cbIncludeTotals.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(163, 43);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(150, 20);
            this.dtpEnd.TabIndex = 4;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(34, 49);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 13);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date: ";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(163, 8);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(150, 20);
            this.dtpStart.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(34, 14);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(61, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboboxReportType);
            this.panel2.Controls.Add(this.lblReportType);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 43);
            this.panel2.TabIndex = 0;
            // 
            // comboboxReportType
            // 
            this.comboboxReportType.FormattingEnabled = true;
            this.comboboxReportType.Location = new System.Drawing.Point(101, 8);
            this.comboboxReportType.Name = "comboboxReportType";
            this.comboboxReportType.Size = new System.Drawing.Size(272, 21);
            this.comboboxReportType.TabIndex = 1;
            this.comboboxReportType.SelectedIndexChanged += new System.EventHandler(this.comboboxReportType_SelectedIndexChanged);
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(26, 11);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(69, 13);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Report Type:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(696, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLanguageSwitch
            // 
            this.btnLanguageSwitch.Location = new System.Drawing.Point(549, 444);
            this.btnLanguageSwitch.Name = "btnLanguageSwitch";
            this.btnLanguageSwitch.Size = new System.Drawing.Size(141, 37);
            this.btnLanguageSwitch.TabIndex = 3;
            this.btnLanguageSwitch.Text = "Afrikaans";
            this.btnLanguageSwitch.UseVisualStyleBackColor = true;
            this.btnLanguageSwitch.Visible = false;
            this.btnLanguageSwitch.Click += new System.EventHandler(this.btnLanguageSwitch_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnLanguageSwitch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.pnlState.ResumeLayout(false);
            this.pnlState.PerformLayout();
            this.pnlEvents.ResumeLayout(false);
            this.pnlEvents.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLanguageSwitch;
        private System.Windows.Forms.Panel pnlEvents;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox comboboxReportType;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.CheckBox cbIncludeTotals;
        private System.Windows.Forms.Panel pnlState;
        private System.Windows.Forms.CheckBox cbTotalState;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}