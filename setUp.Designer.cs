namespace AntonysApps.HouseShare
{
    partial class setUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setUp));
            this.housesLB = new System.Windows.Forms.ListBox();
            this.addHouseTB = new System.Windows.Forms.TextBox();
            this.addHouseButt = new System.Windows.Forms.Button();
            this.deleteHouseButt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.renameHouseButt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.billTypesLB = new System.Windows.Forms.ListBox();
            this.deleteBillType = new System.Windows.Forms.Button();
            this.addBillTypeTB = new System.Windows.Forms.TextBox();
            this.renameBillTypeButt = new System.Windows.Forms.Button();
            this.addBillTypeButt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.housesCB = new System.Windows.Forms.ComboBox();
            this.houseMatesLB = new System.Windows.Forms.ListBox();
            this.deleteHouseMateButt = new System.Windows.Forms.Button();
            this.addHouseMateTB = new System.Windows.Forms.TextBox();
            this.renameHMButt = new System.Windows.Forms.Button();
            this.addHouseMateButt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.housesCB2 = new System.Windows.Forms.ComboBox();
            this.paymentConfChB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // housesLB
            // 
            this.housesLB.FormattingEnabled = true;
            this.housesLB.Items.AddRange(new object[] {
            "House 1",
            "House 2"});
            this.housesLB.Location = new System.Drawing.Point(15, 31);
            this.housesLB.Name = "housesLB";
            this.housesLB.Size = new System.Drawing.Size(128, 95);
            this.housesLB.TabIndex = 2;
            // 
            // addHouseTB
            // 
            this.addHouseTB.Location = new System.Drawing.Point(15, 141);
            this.addHouseTB.Name = "addHouseTB";
            this.addHouseTB.Size = new System.Drawing.Size(104, 20);
            this.addHouseTB.TabIndex = 0;
            // 
            // addHouseButt
            // 
            this.addHouseButt.AutoSize = true;
            this.addHouseButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addHouseButt.Location = new System.Drawing.Point(125, 138);
            this.addHouseButt.Name = "addHouseButt";
            this.addHouseButt.Size = new System.Drawing.Size(36, 23);
            this.addHouseButt.TabIndex = 1;
            this.addHouseButt.Text = "Add";
            this.addHouseButt.UseVisualStyleBackColor = true;
            this.addHouseButt.Click += new System.EventHandler(this.addHouseButt_Click);
            // 
            // deleteHouseButt
            // 
            this.deleteHouseButt.AutoSize = true;
            this.deleteHouseButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteHouseButt.Location = new System.Drawing.Point(149, 60);
            this.deleteHouseButt.Name = "deleteHouseButt";
            this.deleteHouseButt.Size = new System.Drawing.Size(48, 23);
            this.deleteHouseButt.TabIndex = 4;
            this.deleteHouseButt.Text = "Delete";
            this.deleteHouseButt.UseVisualStyleBackColor = true;
            this.deleteHouseButt.Click += new System.EventHandler(this.deleteHouseButt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.housesLB);
            this.groupBox1.Controls.Add(this.deleteHouseButt);
            this.groupBox1.Controls.Add(this.addHouseTB);
            this.groupBox1.Controls.Add(this.renameHouseButt);
            this.groupBox1.Controls.Add(this.addHouseButt);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Houses";
            // 
            // renameHouseButt
            // 
            this.renameHouseButt.AutoSize = true;
            this.renameHouseButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.renameHouseButt.Location = new System.Drawing.Point(149, 31);
            this.renameHouseButt.Name = "renameHouseButt";
            this.renameHouseButt.Size = new System.Drawing.Size(57, 23);
            this.renameHouseButt.TabIndex = 3;
            this.renameHouseButt.Text = "Rename";
            this.renameHouseButt.UseVisualStyleBackColor = true;
            this.renameHouseButt.Click += new System.EventHandler(this.renameHouseButt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.billTypesLB);
            this.groupBox2.Controls.Add(this.deleteBillType);
            this.groupBox2.Controls.Add(this.addBillTypeTB);
            this.groupBox2.Controls.Add(this.renameBillTypeButt);
            this.groupBox2.Controls.Add(this.addBillTypeButt);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 181);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Types";
            // 
            // billTypesLB
            // 
            this.billTypesLB.FormattingEnabled = true;
            this.billTypesLB.Items.AddRange(new object[] {
            "Bill Type 1",
            "Bill Type 2"});
            this.billTypesLB.Location = new System.Drawing.Point(15, 31);
            this.billTypesLB.Name = "billTypesLB";
            this.billTypesLB.Size = new System.Drawing.Size(98, 95);
            this.billTypesLB.TabIndex = 7;
            // 
            // deleteBillType
            // 
            this.deleteBillType.AutoSize = true;
            this.deleteBillType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteBillType.Location = new System.Drawing.Point(119, 60);
            this.deleteBillType.Name = "deleteBillType";
            this.deleteBillType.Size = new System.Drawing.Size(48, 23);
            this.deleteBillType.TabIndex = 9;
            this.deleteBillType.Text = "Delete";
            this.deleteBillType.UseVisualStyleBackColor = true;
            this.deleteBillType.Click += new System.EventHandler(this.deleteBillType_Click);
            // 
            // addBillTypeTB
            // 
            this.addBillTypeTB.Location = new System.Drawing.Point(15, 141);
            this.addBillTypeTB.Name = "addBillTypeTB";
            this.addBillTypeTB.Size = new System.Drawing.Size(98, 20);
            this.addBillTypeTB.TabIndex = 5;
            // 
            // renameBillTypeButt
            // 
            this.renameBillTypeButt.AutoSize = true;
            this.renameBillTypeButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.renameBillTypeButt.Location = new System.Drawing.Point(119, 31);
            this.renameBillTypeButt.Name = "renameBillTypeButt";
            this.renameBillTypeButt.Size = new System.Drawing.Size(57, 23);
            this.renameBillTypeButt.TabIndex = 8;
            this.renameBillTypeButt.Text = "Rename";
            this.renameBillTypeButt.UseVisualStyleBackColor = true;
            this.renameBillTypeButt.Click += new System.EventHandler(this.renameBillTypeButt_Click);
            // 
            // addBillTypeButt
            // 
            this.addBillTypeButt.AutoSize = true;
            this.addBillTypeButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBillTypeButt.Location = new System.Drawing.Point(119, 138);
            this.addBillTypeButt.Name = "addBillTypeButt";
            this.addBillTypeButt.Size = new System.Drawing.Size(36, 23);
            this.addBillTypeButt.TabIndex = 6;
            this.addBillTypeButt.Text = "Add";
            this.addBillTypeButt.UseVisualStyleBackColor = true;
            this.addBillTypeButt.Click += new System.EventHandler(this.addBillTypeButt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.housesCB);
            this.groupBox3.Controls.Add(this.houseMatesLB);
            this.groupBox3.Controls.Add(this.deleteHouseMateButt);
            this.groupBox3.Controls.Add(this.addHouseMateTB);
            this.groupBox3.Controls.Add(this.renameHMButt);
            this.groupBox3.Controls.Add(this.addHouseMateButt);
            this.groupBox3.Location = new System.Drawing.Point(22, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 193);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "House Mates";
            // 
            // housesCB
            // 
            this.housesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.housesCB.FormattingEnabled = true;
            this.housesCB.Location = new System.Drawing.Point(15, 19);
            this.housesCB.Name = "housesCB";
            this.housesCB.Size = new System.Drawing.Size(128, 21);
            this.housesCB.TabIndex = 10;
            this.housesCB.SelectedIndexChanged += new System.EventHandler(this.housesCB_SelectedIndexChanged);
            // 
            // houseMatesLB
            // 
            this.houseMatesLB.FormattingEnabled = true;
            this.houseMatesLB.Items.AddRange(new object[] {
            "Housemate 1",
            "Housemate 2"});
            this.houseMatesLB.Location = new System.Drawing.Point(15, 46);
            this.houseMatesLB.Name = "houseMatesLB";
            this.houseMatesLB.Size = new System.Drawing.Size(146, 95);
            this.houseMatesLB.TabIndex = 13;
            // 
            // deleteHouseMateButt
            // 
            this.deleteHouseMateButt.AutoSize = true;
            this.deleteHouseMateButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteHouseMateButt.Location = new System.Drawing.Point(167, 79);
            this.deleteHouseMateButt.Name = "deleteHouseMateButt";
            this.deleteHouseMateButt.Size = new System.Drawing.Size(48, 23);
            this.deleteHouseMateButt.TabIndex = 15;
            this.deleteHouseMateButt.Text = "Delete";
            this.deleteHouseMateButt.UseVisualStyleBackColor = true;
            this.deleteHouseMateButt.Click += new System.EventHandler(this.deleteHouseMateButt_Click);
            // 
            // addHouseMateTB
            // 
            this.addHouseMateTB.Location = new System.Drawing.Point(15, 160);
            this.addHouseMateTB.Name = "addHouseMateTB";
            this.addHouseMateTB.Size = new System.Drawing.Size(146, 20);
            this.addHouseMateTB.TabIndex = 11;
            // 
            // renameHMButt
            // 
            this.renameHMButt.AutoSize = true;
            this.renameHMButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.renameHMButt.Location = new System.Drawing.Point(167, 50);
            this.renameHMButt.Name = "renameHMButt";
            this.renameHMButt.Size = new System.Drawing.Size(57, 23);
            this.renameHMButt.TabIndex = 14;
            this.renameHMButt.Text = "Rename";
            this.renameHMButt.UseVisualStyleBackColor = true;
            this.renameHMButt.Click += new System.EventHandler(this.renameHMButt_Click);
            // 
            // addHouseMateButt
            // 
            this.addHouseMateButt.AutoSize = true;
            this.addHouseMateButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addHouseMateButt.Location = new System.Drawing.Point(167, 157);
            this.addHouseMateButt.Name = "addHouseMateButt";
            this.addHouseMateButt.Size = new System.Drawing.Size(36, 23);
            this.addHouseMateButt.TabIndex = 12;
            this.addHouseMateButt.Text = "Add";
            this.addHouseMateButt.UseVisualStyleBackColor = true;
            this.addHouseMateButt.Click += new System.EventHandler(this.addHouseMateButt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.housesCB2);
            this.groupBox4.Controls.Add(this.paymentConfChB);
            this.groupBox4.Location = new System.Drawing.Point(280, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 193);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "House Settings";
            // 
            // housesCB2
            // 
            this.housesCB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.housesCB2.FormattingEnabled = true;
            this.housesCB2.Location = new System.Drawing.Point(20, 19);
            this.housesCB2.Name = "housesCB2";
            this.housesCB2.Size = new System.Drawing.Size(128, 21);
            this.housesCB2.TabIndex = 11;
            this.housesCB2.SelectedIndexChanged += new System.EventHandler(this.housesCB2_SelectedIndexChanged);
            // 
            // paymentConfChB
            // 
            this.paymentConfChB.AutoSize = true;
            this.paymentConfChB.Checked = true;
            this.paymentConfChB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.paymentConfChB.Enabled = false;
            this.paymentConfChB.Location = new System.Drawing.Point(9, 84);
            this.paymentConfChB.Name = "paymentConfChB";
            this.paymentConfChB.Size = new System.Drawing.Size(148, 17);
            this.paymentConfChB.TabIndex = 10;
            this.paymentConfChB.Text = "Use payment confirmation";
            this.paymentConfChB.UseVisualStyleBackColor = true;
            this.paymentConfChB.CheckedChanged += new System.EventHandler(this.paymentConfChB_CheckedChanged);
            // 
            // setUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 407);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "setUp";
            this.Text = "HouseShare - Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox housesLB;
        private System.Windows.Forms.TextBox addHouseTB;
        private System.Windows.Forms.Button addHouseButt;
        private System.Windows.Forms.Button deleteHouseButt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox billTypesLB;
        private System.Windows.Forms.Button deleteBillType;
        private System.Windows.Forms.TextBox addBillTypeTB;
        private System.Windows.Forms.Button renameBillTypeButt;
        private System.Windows.Forms.Button addBillTypeButt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox housesCB;
        private System.Windows.Forms.ListBox houseMatesLB;
        private System.Windows.Forms.Button deleteHouseMateButt;
        private System.Windows.Forms.TextBox addHouseMateTB;
        private System.Windows.Forms.Button renameHMButt;
        private System.Windows.Forms.Button addHouseMateButt;
        private System.Windows.Forms.Button renameHouseButt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox housesCB2;
        private System.Windows.Forms.CheckBox paymentConfChB;
    }
}