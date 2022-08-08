namespace CMPG223_Group15
{
    partial class BuyOrSell
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
            this.tabBuyTextbooks = new System.Windows.Forms.TabControl();
            this.tabHandout = new System.Windows.Forms.TabPage();
            this.tbAmountSold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbbTextbooks = new System.Windows.Forms.ComboBox();
            this.btnDisplayInventory = new System.Windows.Forms.Button();
            this.btnDisplayTextbooks = new System.Windows.Forms.Button();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRecieve = new System.Windows.Forms.TabPage();
            this.btnDisplayAuthorsOnBuy = new System.Windows.Forms.Button();
            this.btnBuyDisplayTextBook = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTextbookName = new System.Windows.Forms.TextBox();
            this.btnRecieveClear = new System.Windows.Forms.Button();
            this.btnRecieveSubmit = new System.Windows.Forms.Button();
            this.cbbAuthorRecieve = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabBuyTextbooks.SuspendLayout();
            this.tabHandout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.tabRecieve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBuyTextbooks
            // 
            this.tabBuyTextbooks.Controls.Add(this.tabHandout);
            this.tabBuyTextbooks.Controls.Add(this.tabRecieve);
            this.tabBuyTextbooks.Location = new System.Drawing.Point(3, 3);
            this.tabBuyTextbooks.Name = "tabBuyTextbooks";
            this.tabBuyTextbooks.SelectedIndex = 0;
            this.tabBuyTextbooks.Size = new System.Drawing.Size(795, 377);
            this.tabBuyTextbooks.TabIndex = 1;
            // 
            // tabHandout
            // 
            this.tabHandout.Controls.Add(this.tbAmountSold);
            this.tabHandout.Controls.Add(this.label2);
            this.tabHandout.Controls.Add(this.btnClear);
            this.tabHandout.Controls.Add(this.btnSubmit);
            this.tabHandout.Controls.Add(this.cbbTextbooks);
            this.tabHandout.Controls.Add(this.btnDisplayInventory);
            this.tabHandout.Controls.Add(this.btnDisplayTextbooks);
            this.tabHandout.Controls.Add(this.dgDisplay);
            this.tabHandout.Controls.Add(this.label1);
            this.tabHandout.Location = new System.Drawing.Point(4, 22);
            this.tabHandout.Name = "tabHandout";
            this.tabHandout.Padding = new System.Windows.Forms.Padding(3);
            this.tabHandout.Size = new System.Drawing.Size(787, 351);
            this.tabHandout.TabIndex = 0;
            this.tabHandout.Text = "Sell Textbooks";
            this.tabHandout.UseVisualStyleBackColor = true;
            this.tabHandout.Click += new System.EventHandler(this.tabHandout_Click_1);
            // 
            // tbAmountSold
            // 
            this.tbAmountSold.Location = new System.Drawing.Point(381, 218);
            this.tbAmountSold.Name = "tbAmountSold";
            this.tbAmountSold.Size = new System.Drawing.Size(116, 20);
            this.tbAmountSold.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Amount sold for:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(305, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 26);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(383, 258);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 26);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // cbbTextbooks
            // 
            this.cbbTextbooks.FormattingEnabled = true;
            this.cbbTextbooks.Location = new System.Drawing.Point(381, 190);
            this.cbbTextbooks.Name = "cbbTextbooks";
            this.cbbTextbooks.Size = new System.Drawing.Size(116, 21);
            this.cbbTextbooks.TabIndex = 11;
            this.cbbTextbooks.SelectedIndexChanged += new System.EventHandler(this.cbbTextbooks_SelectedIndexChanged);
            // 
            // btnDisplayInventory
            // 
            this.btnDisplayInventory.Location = new System.Drawing.Point(669, 88);
            this.btnDisplayInventory.Name = "btnDisplayInventory";
            this.btnDisplayInventory.Size = new System.Drawing.Size(112, 64);
            this.btnDisplayInventory.TabIndex = 9;
            this.btnDisplayInventory.Text = "Display textbook inventory";
            this.btnDisplayInventory.UseVisualStyleBackColor = true;
            this.btnDisplayInventory.Visible = false;
            this.btnDisplayInventory.Click += new System.EventHandler(this.btnDisplayInventory_Click_1);
            // 
            // btnDisplayTextbooks
            // 
            this.btnDisplayTextbooks.Location = new System.Drawing.Point(669, 19);
            this.btnDisplayTextbooks.Name = "btnDisplayTextbooks";
            this.btnDisplayTextbooks.Size = new System.Drawing.Size(112, 63);
            this.btnDisplayTextbooks.TabIndex = 8;
            this.btnDisplayTextbooks.Text = "Display all textbooks";
            this.btnDisplayTextbooks.UseVisualStyleBackColor = true;
            this.btnDisplayTextbooks.Click += new System.EventHandler(this.btnDisplayTextbooks_Click_1);
            // 
            // dgDisplay
            // 
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Location = new System.Drawing.Point(17, 6);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.RowHeadersWidth = 51;
            this.dgDisplay.Size = new System.Drawing.Size(646, 162);
            this.dgDisplay.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the textbook ID to sell:";
            // 
            // tabRecieve
            // 
            this.tabRecieve.Controls.Add(this.btnDisplayAuthorsOnBuy);
            this.tabRecieve.Controls.Add(this.btnBuyDisplayTextBook);
            this.tabRecieve.Controls.Add(this.dataGridView1);
            this.tabRecieve.Controls.Add(this.tBoxID);
            this.tabRecieve.Controls.Add(this.label6);
            this.tabRecieve.Controls.Add(this.label5);
            this.tabRecieve.Controls.Add(this.tbPrice);
            this.tabRecieve.Controls.Add(this.label3);
            this.tabRecieve.Controls.Add(this.tbTextbookName);
            this.tabRecieve.Controls.Add(this.btnRecieveClear);
            this.tabRecieve.Controls.Add(this.btnRecieveSubmit);
            this.tabRecieve.Controls.Add(this.cbbAuthorRecieve);
            this.tabRecieve.Controls.Add(this.label4);
            this.tabRecieve.Location = new System.Drawing.Point(4, 22);
            this.tabRecieve.Name = "tabRecieve";
            this.tabRecieve.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecieve.Size = new System.Drawing.Size(787, 351);
            this.tabRecieve.TabIndex = 1;
            this.tabRecieve.Text = "Buy Textbooks";
            this.tabRecieve.UseVisualStyleBackColor = true;
            this.tabRecieve.Click += new System.EventHandler(this.tabRecieve_Click);
            // 
            // btnDisplayAuthorsOnBuy
            // 
            this.btnDisplayAuthorsOnBuy.Location = new System.Drawing.Point(675, 74);
            this.btnDisplayAuthorsOnBuy.Name = "btnDisplayAuthorsOnBuy";
            this.btnDisplayAuthorsOnBuy.Size = new System.Drawing.Size(106, 62);
            this.btnDisplayAuthorsOnBuy.TabIndex = 32;
            this.btnDisplayAuthorsOnBuy.Text = "Display Authors";
            this.btnDisplayAuthorsOnBuy.UseVisualStyleBackColor = true;
            this.btnDisplayAuthorsOnBuy.Click += new System.EventHandler(this.btnDisplayAuthorsOnBuy_Click);
            // 
            // btnBuyDisplayTextBook
            // 
            this.btnBuyDisplayTextBook.Location = new System.Drawing.Point(675, 6);
            this.btnBuyDisplayTextBook.Name = "btnBuyDisplayTextBook";
            this.btnBuyDisplayTextBook.Size = new System.Drawing.Size(106, 62);
            this.btnBuyDisplayTextBook.TabIndex = 31;
            this.btnBuyDisplayTextBook.Text = "Display all textbooks";
            this.btnBuyDisplayTextBook.UseVisualStyleBackColor = true;
            this.btnBuyDisplayTextBook.Click += new System.EventHandler(this.btnBuyDisplayTextBook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(663, 158);
            this.dataGridView1.TabIndex = 30;
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(371, 170);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(100, 20);
            this.tBoxID.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Textbook ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Book Price :";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(371, 272);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Textbook Name :";
            // 
            // tbTextbookName
            // 
            this.tbTextbookName.Location = new System.Drawing.Point(371, 236);
            this.tbTextbookName.Name = "tbTextbookName";
            this.tbTextbookName.Size = new System.Drawing.Size(100, 20);
            this.tbTextbookName.TabIndex = 24;
            // 
            // btnRecieveClear
            // 
            this.btnRecieveClear.Location = new System.Drawing.Point(301, 307);
            this.btnRecieveClear.Name = "btnRecieveClear";
            this.btnRecieveClear.Size = new System.Drawing.Size(64, 26);
            this.btnRecieveClear.TabIndex = 23;
            this.btnRecieveClear.Text = "Clear";
            this.btnRecieveClear.UseVisualStyleBackColor = true;
            this.btnRecieveClear.Click += new System.EventHandler(this.btnRecieveClear_Click);
            // 
            // btnRecieveSubmit
            // 
            this.btnRecieveSubmit.Location = new System.Drawing.Point(371, 307);
            this.btnRecieveSubmit.Name = "btnRecieveSubmit";
            this.btnRecieveSubmit.Size = new System.Drawing.Size(115, 26);
            this.btnRecieveSubmit.TabIndex = 22;
            this.btnRecieveSubmit.Text = "Submit";
            this.btnRecieveSubmit.UseVisualStyleBackColor = true;
            this.btnRecieveSubmit.Click += new System.EventHandler(this.btnRecieveSubmit_Click);
            // 
            // cbbAuthorRecieve
            // 
            this.cbbAuthorRecieve.FormattingEnabled = true;
            this.cbbAuthorRecieve.Location = new System.Drawing.Point(371, 204);
            this.cbbAuthorRecieve.Name = "cbbAuthorRecieve";
            this.cbbAuthorRecieve.Size = new System.Drawing.Size(100, 21);
            this.cbbAuthorRecieve.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select Author ID :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(696, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 41);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BuyOrSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabBuyTextbooks);
            this.Name = "BuyOrSell";
            this.Text = "BuyOrSell";
            this.Load += new System.EventHandler(this.BuyOrSell_Load);
            this.tabBuyTextbooks.ResumeLayout(false);
            this.tabHandout.ResumeLayout(false);
            this.tabHandout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.tabRecieve.ResumeLayout(false);
            this.tabRecieve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBuyTextbooks;
        private System.Windows.Forms.TabPage tabHandout;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbbTextbooks;
        private System.Windows.Forms.Button btnDisplayInventory;
        private System.Windows.Forms.Button btnDisplayTextbooks;
        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRecieve;
        private System.Windows.Forms.Button btnRecieveClear;
        private System.Windows.Forms.Button btnRecieveSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbAmountSold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbAuthorRecieve;
        private System.Windows.Forms.TextBox tbTextbookName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDisplayAuthorsOnBuy;
        private System.Windows.Forms.Button btnBuyDisplayTextBook;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}