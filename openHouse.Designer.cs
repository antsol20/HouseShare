namespace AntonysApps.HouseShare
{
    partial class openHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openHouse));
            this.houseMatesLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalBalOSLbl = new System.Windows.Forms.Label();
            this.matesBalLB = new System.Windows.Forms.ListBox();
            this.enterPayInButt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.houseMatesCB = new System.Windows.Forms.ComboBox();
            this.payInDT = new System.Windows.Forms.DateTimePicker();
            this.payOutDT = new System.Windows.Forms.DateTimePicker();
            this.billTypeCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.enterPayOutButt = new System.Windows.Forms.Button();
            this.payIn1TB = new System.Windows.Forms.TextBox();
            this.payIn2TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.payOut2TB = new System.Windows.Forms.TextBox();
            this.payOut1TB = new System.Windows.Forms.TextBox();
            this.hmBalLB = new System.Windows.Forms.ListBox();
            this.payOutNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.viewPaymentsButt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // houseMatesLB
            // 
            this.houseMatesLB.FormattingEnabled = true;
            this.houseMatesLB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.houseMatesLB.Location = new System.Drawing.Point(16, 55);
            this.houseMatesLB.Name = "houseMatesLB";
            this.houseMatesLB.Size = new System.Drawing.Size(108, 121);
            this.houseMatesLB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "House Mates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Balance Outstanding";
            // 
            // totalBalOSLbl
            // 
            this.totalBalOSLbl.AutoSize = true;
            this.totalBalOSLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBalOSLbl.Location = new System.Drawing.Point(188, 216);
            this.totalBalOSLbl.Name = "totalBalOSLbl";
            this.totalBalOSLbl.Size = new System.Drawing.Size(46, 13);
            this.totalBalOSLbl.TabIndex = 7;
            this.totalBalOSLbl.Text = "100.11";
            // 
            // matesBalLB
            // 
            this.matesBalLB.FormattingEnabled = true;
            this.matesBalLB.Items.AddRange(new object[] {
            "0",
            "0",
            "0",
            "0",
            "0"});
            this.matesBalLB.Location = new System.Drawing.Point(130, 55);
            this.matesBalLB.Name = "matesBalLB";
            this.matesBalLB.Size = new System.Drawing.Size(51, 121);
            this.matesBalLB.TabIndex = 10;
            // 
            // enterPayInButt
            // 
            this.enterPayInButt.Location = new System.Drawing.Point(214, 59);
            this.enterPayInButt.Name = "enterPayInButt";
            this.enterPayInButt.Size = new System.Drawing.Size(86, 31);
            this.enterPayInButt.TabIndex = 4;
            this.enterPayInButt.Text = "Enter Payment";
            this.enterPayInButt.UseVisualStyleBackColor = true;
            this.enterPayInButt.Click += new System.EventHandler(this.enterPayInButt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Payment in from House Mate";
            // 
            // houseMatesCB
            // 
            this.houseMatesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.houseMatesCB.FormattingEnabled = true;
            this.houseMatesCB.Location = new System.Drawing.Point(19, 65);
            this.houseMatesCB.Name = "houseMatesCB";
            this.houseMatesCB.Size = new System.Drawing.Size(116, 21);
            this.houseMatesCB.TabIndex = 0;
            // 
            // payInDT
            // 
            this.payInDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payInDT.Location = new System.Drawing.Point(19, 92);
            this.payInDT.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.payInDT.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.payInDT.Name = "payInDT";
            this.payInDT.Size = new System.Drawing.Size(88, 20);
            this.payInDT.TabIndex = 3;
            // 
            // payOutDT
            // 
            this.payOutDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payOutDT.Location = new System.Drawing.Point(19, 244);
            this.payOutDT.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.payOutDT.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.payOutDT.Name = "payOutDT";
            this.payOutDT.Size = new System.Drawing.Size(88, 20);
            this.payOutDT.TabIndex = 9;
            // 
            // billTypeCB
            // 
            this.billTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.billTypeCB.FormattingEnabled = true;
            this.billTypeCB.Location = new System.Drawing.Point(19, 191);
            this.billTypeCB.Name = "billTypeCB";
            this.billTypeCB.Size = new System.Drawing.Size(116, 21);
            this.billTypeCB.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Payment Out for Bill";
            // 
            // enterPayOutButt
            // 
            this.enterPayOutButt.Location = new System.Drawing.Point(214, 185);
            this.enterPayOutButt.Name = "enterPayOutButt";
            this.enterPayOutButt.Size = new System.Drawing.Size(86, 31);
            this.enterPayOutButt.TabIndex = 10;
            this.enterPayOutButt.Text = "Enter Payment";
            this.enterPayOutButt.UseVisualStyleBackColor = true;
            this.enterPayOutButt.Click += new System.EventHandler(this.enterPayOutButt_Click);
            // 
            // payIn1TB
            // 
            this.payIn1TB.Location = new System.Drawing.Point(141, 65);
            this.payIn1TB.Name = "payIn1TB";
            this.payIn1TB.Size = new System.Drawing.Size(32, 20);
            this.payIn1TB.TabIndex = 1;
            // 
            // payIn2TB
            // 
            this.payIn2TB.Location = new System.Drawing.Point(184, 65);
            this.payIn2TB.Name = "payIn2TB";
            this.payIn2TB.Size = new System.Drawing.Size(21, 20);
            this.payIn2TB.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(173, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(173, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "-";
            // 
            // payOut2TB
            // 
            this.payOut2TB.Location = new System.Drawing.Point(184, 191);
            this.payOut2TB.Name = "payOut2TB";
            this.payOut2TB.Size = new System.Drawing.Size(21, 20);
            this.payOut2TB.TabIndex = 7;
            // 
            // payOut1TB
            // 
            this.payOut1TB.Location = new System.Drawing.Point(141, 191);
            this.payOut1TB.Name = "payOut1TB";
            this.payOut1TB.Size = new System.Drawing.Size(32, 20);
            this.payOut1TB.TabIndex = 6;
            // 
            // hmBalLB
            // 
            this.hmBalLB.FormattingEnabled = true;
            this.hmBalLB.Items.AddRange(new object[] {
            "0",
            "0",
            "0",
            "0",
            "0"});
            this.hmBalLB.Location = new System.Drawing.Point(187, 55);
            this.hmBalLB.Name = "hmBalLB";
            this.hmBalLB.Size = new System.Drawing.Size(51, 121);
            this.hmBalLB.TabIndex = 30;
            // 
            // payOutNotes
            // 
            this.payOutNotes.Location = new System.Drawing.Point(19, 218);
            this.payOutNotes.Name = "payOutNotes";
            this.payOutNotes.Size = new System.Drawing.Size(186, 20);
            this.payOutNotes.TabIndex = 8;
            this.payOutNotes.Text = "Notes";
            this.payOutNotes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.payOutNotes_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Balance*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Paid";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 34);
            this.label6.TabIndex = 34;
            this.label6.Text = "*a negative housemate account balance indicates money owed to the housemate from " +
                "the house account";
            // 
            // viewPaymentsButt
            // 
            this.viewPaymentsButt.Location = new System.Drawing.Point(208, 289);
            this.viewPaymentsButt.Name = "viewPaymentsButt";
            this.viewPaymentsButt.Size = new System.Drawing.Size(110, 23);
            this.viewPaymentsButt.TabIndex = 11;
            this.viewPaymentsButt.Text = "View Payment Data";
            this.viewPaymentsButt.UseVisualStyleBackColor = true;
            this.viewPaymentsButt.Click += new System.EventHandler(this.viewPaymentsButt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.enterPayInButt);
            this.groupBox1.Controls.Add(this.houseMatesCB);
            this.groupBox1.Controls.Add(this.viewPaymentsButt);
            this.groupBox1.Controls.Add(this.payInDT);
            this.groupBox1.Controls.Add(this.enterPayOutButt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.billTypeCB);
            this.groupBox1.Controls.Add(this.payOutNotes);
            this.groupBox1.Controls.Add(this.payOutDT);
            this.groupBox1.Controls.Add(this.payIn1TB);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.payIn2TB);
            this.groupBox1.Controls.Add(this.payOut2TB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.payOut1TB);
            this.groupBox1.Location = new System.Drawing.Point(294, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 320);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payments";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.houseMatesLB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.totalBalOSLbl);
            this.groupBox2.Controls.Add(this.matesBalLB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.hmBalLB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 264);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // openHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "openHouse";
            this.Text = "HouseShare";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox houseMatesLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalBalOSLbl;
        private System.Windows.Forms.ListBox matesBalLB;
        private System.Windows.Forms.Button enterPayInButt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox houseMatesCB;
        private System.Windows.Forms.DateTimePicker payInDT;
        private System.Windows.Forms.DateTimePicker payOutDT;
        private System.Windows.Forms.ComboBox billTypeCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button enterPayOutButt;
        private System.Windows.Forms.TextBox payIn1TB;
        private System.Windows.Forms.TextBox payIn2TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox payOut2TB;
        private System.Windows.Forms.TextBox payOut1TB;
        private System.Windows.Forms.ListBox hmBalLB;
        private System.Windows.Forms.TextBox payOutNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button viewPaymentsButt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}