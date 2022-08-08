
namespace CMPG223_Group15
{
    partial class TextbookExchangeForm
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
            this.tabHandoutorRecieve = new System.Windows.Forms.TabControl();
            this.tabHandout = new System.Windows.Forms.TabPage();
            this.btnDisplayTradingDates = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbbScholars = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTextbooks = new System.Windows.Forms.ComboBox();
            this.btnDisplayScholars = new System.Windows.Forms.Button();
            this.btnDisplayInventory = new System.Windows.Forms.Button();
            this.btnDisplayTextbooks = new System.Windows.Forms.Button();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRecieve = new System.Windows.Forms.TabPage();
            this.btnRecieveClear = new System.Windows.Forms.Button();
            this.btnRecieveSubmit = new System.Windows.Forms.Button();
            this.cbbRecieveScholar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbRecieveTextbook = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisplayTradingDates2 = new System.Windows.Forms.Button();
            this.btnDisplayScholars2 = new System.Windows.Forms.Button();
            this.btnDisplayInventory2 = new System.Windows.Forms.Button();
            this.btnDisplayTextbooks2 = new System.Windows.Forms.Button();
            this.dgDisplayRecieve = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabHandoutorRecieve.SuspendLayout();
            this.tabHandout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.tabRecieve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplayRecieve)).BeginInit();
            this.SuspendLayout();
            // 
            // tabHandoutorRecieve
            // 
            this.tabHandoutorRecieve.Controls.Add(this.tabHandout);
            this.tabHandoutorRecieve.Controls.Add(this.tabRecieve);
            this.tabHandoutorRecieve.Location = new System.Drawing.Point(12, 12);
            this.tabHandoutorRecieve.Name = "tabHandoutorRecieve";
            this.tabHandoutorRecieve.SelectedIndex = 0;
            this.tabHandoutorRecieve.Size = new System.Drawing.Size(795, 311);
            this.tabHandoutorRecieve.TabIndex = 0;
            // 
            // tabHandout
            // 
            this.tabHandout.Controls.Add(this.btnDisplayTradingDates);
            this.tabHandout.Controls.Add(this.btnClear);
            this.tabHandout.Controls.Add(this.btnSubmit);
            this.tabHandout.Controls.Add(this.cbbScholars);
            this.tabHandout.Controls.Add(this.label2);
            this.tabHandout.Controls.Add(this.cbbTextbooks);
            this.tabHandout.Controls.Add(this.btnDisplayScholars);
            this.tabHandout.Controls.Add(this.btnDisplayInventory);
            this.tabHandout.Controls.Add(this.btnDisplayTextbooks);
            this.tabHandout.Controls.Add(this.dgDisplay);
            this.tabHandout.Controls.Add(this.label1);
            this.tabHandout.Location = new System.Drawing.Point(4, 22);
            this.tabHandout.Name = "tabHandout";
            this.tabHandout.Padding = new System.Windows.Forms.Padding(3);
            this.tabHandout.Size = new System.Drawing.Size(787, 285);
            this.tabHandout.TabIndex = 0;
            this.tabHandout.Text = "Handout Textbook";
            this.tabHandout.UseVisualStyleBackColor = true;
            // 
            // btnDisplayTradingDates
            // 
            this.btnDisplayTradingDates.Location = new System.Drawing.Point(637, 132);
            this.btnDisplayTradingDates.Name = "btnDisplayTradingDates";
            this.btnDisplayTradingDates.Size = new System.Drawing.Size(140, 36);
            this.btnDisplayTradingDates.TabIndex = 16;
            this.btnDisplayTradingDates.Text = "Display Trading Dates";
            this.btnDisplayTradingDates.UseVisualStyleBackColor = true;
            this.btnDisplayTradingDates.Click += new System.EventHandler(this.btnDisplayTradingDates_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(179, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 26);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(267, 236);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 26);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbbScholars
            // 
            this.cbbScholars.FormattingEnabled = true;
            this.cbbScholars.Location = new System.Drawing.Point(233, 209);
            this.cbbScholars.Name = "cbbScholars";
            this.cbbScholars.Size = new System.Drawing.Size(116, 21);
            this.cbbScholars.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select the recieving scholar\'s ID:";
            // 
            // cbbTextbooks
            // 
            this.cbbTextbooks.FormattingEnabled = true;
            this.cbbTextbooks.Location = new System.Drawing.Point(233, 182);
            this.cbbTextbooks.Name = "cbbTextbooks";
            this.cbbTextbooks.Size = new System.Drawing.Size(116, 21);
            this.cbbTextbooks.TabIndex = 11;
            // 
            // btnDisplayScholars
            // 
            this.btnDisplayScholars.Location = new System.Drawing.Point(637, 90);
            this.btnDisplayScholars.Name = "btnDisplayScholars";
            this.btnDisplayScholars.Size = new System.Drawing.Size(140, 36);
            this.btnDisplayScholars.TabIndex = 10;
            this.btnDisplayScholars.Text = "Display all scholars";
            this.btnDisplayScholars.UseVisualStyleBackColor = true;
            this.btnDisplayScholars.Click += new System.EventHandler(this.btnDisplayScholars_Click);
            // 
            // btnDisplayInventory
            // 
            this.btnDisplayInventory.Location = new System.Drawing.Point(637, 48);
            this.btnDisplayInventory.Name = "btnDisplayInventory";
            this.btnDisplayInventory.Size = new System.Drawing.Size(140, 36);
            this.btnDisplayInventory.TabIndex = 9;
            this.btnDisplayInventory.Text = "Display textbook inventory";
            this.btnDisplayInventory.UseVisualStyleBackColor = true;
            this.btnDisplayInventory.Click += new System.EventHandler(this.btnDisplayInventory_Click);
            // 
            // btnDisplayTextbooks
            // 
            this.btnDisplayTextbooks.Location = new System.Drawing.Point(637, 6);
            this.btnDisplayTextbooks.Name = "btnDisplayTextbooks";
            this.btnDisplayTextbooks.Size = new System.Drawing.Size(140, 36);
            this.btnDisplayTextbooks.TabIndex = 8;
            this.btnDisplayTextbooks.Text = "Display all textbooks";
            this.btnDisplayTextbooks.UseVisualStyleBackColor = true;
            this.btnDisplayTextbooks.Click += new System.EventHandler(this.btnDisplayTextbooks_Click);
            // 
            // dgDisplay
            // 
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Location = new System.Drawing.Point(6, 6);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.Size = new System.Drawing.Size(625, 162);
            this.dgDisplay.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the textbook ID to handout:";
            // 
            // tabRecieve
            // 
            this.tabRecieve.Controls.Add(this.btnRecieveClear);
            this.tabRecieve.Controls.Add(this.btnRecieveSubmit);
            this.tabRecieve.Controls.Add(this.cbbRecieveScholar);
            this.tabRecieve.Controls.Add(this.label3);
            this.tabRecieve.Controls.Add(this.cbbRecieveTextbook);
            this.tabRecieve.Controls.Add(this.label4);
            this.tabRecieve.Controls.Add(this.btnDisplayTradingDates2);
            this.tabRecieve.Controls.Add(this.btnDisplayScholars2);
            this.tabRecieve.Controls.Add(this.btnDisplayInventory2);
            this.tabRecieve.Controls.Add(this.btnDisplayTextbooks2);
            this.tabRecieve.Controls.Add(this.dgDisplayRecieve);
            this.tabRecieve.Location = new System.Drawing.Point(4, 22);
            this.tabRecieve.Name = "tabRecieve";
            this.tabRecieve.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecieve.Size = new System.Drawing.Size(787, 285);
            this.tabRecieve.TabIndex = 1;
            this.tabRecieve.Text = "Recieve Textbook";
            this.tabRecieve.UseVisualStyleBackColor = true;
            // 
            // btnRecieveClear
            // 
            this.btnRecieveClear.Location = new System.Drawing.Point(179, 236);
            this.btnRecieveClear.Name = "btnRecieveClear";
            this.btnRecieveClear.Size = new System.Drawing.Size(82, 26);
            this.btnRecieveClear.TabIndex = 23;
            this.btnRecieveClear.Text = "Clear";
            this.btnRecieveClear.UseVisualStyleBackColor = true;
            this.btnRecieveClear.Click += new System.EventHandler(this.btnRecieveClear_Click);
            // 
            // btnRecieveSubmit
            // 
            this.btnRecieveSubmit.Location = new System.Drawing.Point(267, 236);
            this.btnRecieveSubmit.Name = "btnRecieveSubmit";
            this.btnRecieveSubmit.Size = new System.Drawing.Size(82, 26);
            this.btnRecieveSubmit.TabIndex = 22;
            this.btnRecieveSubmit.Text = "Submit";
            this.btnRecieveSubmit.UseVisualStyleBackColor = true;
            this.btnRecieveSubmit.Click += new System.EventHandler(this.btnRecieveSubmit_Click);
            // 
            // cbbRecieveScholar
            // 
            this.cbbRecieveScholar.FormattingEnabled = true;
            this.cbbRecieveScholar.Location = new System.Drawing.Point(233, 209);
            this.cbbRecieveScholar.Name = "cbbRecieveScholar";
            this.cbbRecieveScholar.Size = new System.Drawing.Size(116, 21);
            this.cbbRecieveScholar.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Select the returning scholar\'s ID:";
            // 
            // cbbRecieveTextbook
            // 
            this.cbbRecieveTextbook.FormattingEnabled = true;
            this.cbbRecieveTextbook.Location = new System.Drawing.Point(233, 182);
            this.cbbRecieveTextbook.Name = "cbbRecieveTextbook";
            this.cbbRecieveTextbook.Size = new System.Drawing.Size(116, 21);
            this.cbbRecieveTextbook.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select recieved textbook ID:";
            // 
            // btnDisplayTradingDates2
            // 
            this.btnDisplayTradingDates2.Location = new System.Drawing.Point(637, 132);
            this.btnDisplayTradingDates2.Name = "btnDisplayTradingDates2";
            this.btnDisplayTradingDates2.Size = new System.Drawing.Size(140, 36);
            this.btnDisplayTradingDates2.TabIndex = 17;
            this.btnDisplayTradingDates2.Text = "Display Trading Dates";
            this.btnDisplayTradingDates2.UseVisualStyleBackColor = true;
            this.btnDisplayTradingDates2.Click += new System.EventHandler(this.btnDisplayTradingDates2_Click);
            // 
            // btnDisplayScholars2
            // 
            this.btnDisplayScholars2.Location = new System.Drawing.Point(637, 90);
            this.btnDisplayScholars2.Name = "btnDisplayScholars2";
            this.btnDisplayScholars2.Size = new System.Drawing.Size(140, 36);
            this.btnDisplayScholars2.TabIndex = 13;
            this.btnDisplayScholars2.Text = "Display all scholars";
            this.btnDisplayScholars2.UseVisualStyleBackColor = true;
            this.btnDisplayScholars2.Click += new System.EventHandler(this.btnDisplayScholars2_Click);
            // 
            // btnDisplayInventory2
            // 
            this.btnDisplayInventory2.Location = new System.Drawing.Point(637, 48);
            this.btnDisplayInventory2.Name = "btnDisplayInventory2";
            this.btnDisplayInventory2.Size = new System.Drawing.Size(140, 36);
            this.btnDisplayInventory2.TabIndex = 12;
            this.btnDisplayInventory2.Text = "Display textbook inventory";
            this.btnDisplayInventory2.UseVisualStyleBackColor = true;
            this.btnDisplayInventory2.Click += new System.EventHandler(this.btnDisplayInventory2_Click);
            // 
            // btnDisplayTextbooks2
            // 
            this.btnDisplayTextbooks2.Location = new System.Drawing.Point(637, 6);
            this.btnDisplayTextbooks2.Name = "btnDisplayTextbooks2";
            this.btnDisplayTextbooks2.Size = new System.Drawing.Size(140, 36);
            this.btnDisplayTextbooks2.TabIndex = 11;
            this.btnDisplayTextbooks2.Text = "Display all textbooks";
            this.btnDisplayTextbooks2.UseVisualStyleBackColor = true;
            this.btnDisplayTextbooks2.Click += new System.EventHandler(this.btnDisplayTextbooks2_Click);
            // 
            // dgDisplayRecieve
            // 
            this.dgDisplayRecieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplayRecieve.Location = new System.Drawing.Point(6, 6);
            this.dgDisplayRecieve.Name = "dgDisplayRecieve";
            this.dgDisplayRecieve.Size = new System.Drawing.Size(625, 162);
            this.dgDisplayRecieve.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(703, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 41);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TextbookExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 392);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabHandoutorRecieve);
            this.Name = "TextbookExchangeForm";
            this.Text = "Textbook Exchange";
            this.Load += new System.EventHandler(this.TextbookExchangeForm_Load);
            this.tabHandoutorRecieve.ResumeLayout(false);
            this.tabHandout.ResumeLayout(false);
            this.tabHandout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.tabRecieve.ResumeLayout(false);
            this.tabRecieve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplayRecieve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabHandoutorRecieve;
        private System.Windows.Forms.TabPage tabHandout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRecieve;
        private System.Windows.Forms.DataGridView dgDisplayRecieve;
        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.Button btnDisplayScholars;
        private System.Windows.Forms.Button btnDisplayInventory;
        private System.Windows.Forms.Button btnDisplayTextbooks;
        private System.Windows.Forms.Button btnDisplayScholars2;
        private System.Windows.Forms.Button btnDisplayInventory2;
        private System.Windows.Forms.Button btnDisplayTextbooks2;
        private System.Windows.Forms.ComboBox cbbTextbooks;
        private System.Windows.Forms.ComboBox cbbScholars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisplayTradingDates;
        private System.Windows.Forms.Button btnDisplayTradingDates2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRecieveClear;
        private System.Windows.Forms.Button btnRecieveSubmit;
        private System.Windows.Forms.ComboBox cbbRecieveScholar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbRecieveTextbook;
        private System.Windows.Forms.Label label4;
    }
}