namespace AntonysApps.HouseShare
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.housesCB = new System.Windows.Forms.ComboBox();
            this.openHouseButt = new System.Windows.Forms.Button();
            this.aboutLbl = new System.Windows.Forms.Label();
            this.websiteLinkLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // housesCB
            // 
            this.housesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.housesCB.FormattingEnabled = true;
            this.housesCB.Location = new System.Drawing.Point(23, 5);
            this.housesCB.Name = "housesCB";
            this.housesCB.Size = new System.Drawing.Size(188, 21);
            this.housesCB.TabIndex = 0;
            // 
            // openHouseButt
            // 
            this.openHouseButt.AutoSize = true;
            this.openHouseButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openHouseButt.Location = new System.Drawing.Point(228, 3);
            this.openHouseButt.Name = "openHouseButt";
            this.openHouseButt.Size = new System.Drawing.Size(43, 23);
            this.openHouseButt.TabIndex = 1;
            this.openHouseButt.Text = "Open";
            this.openHouseButt.UseVisualStyleBackColor = true;
            this.openHouseButt.Click += new System.EventHandler(this.openHouseButt_Click);
            // 
            // aboutLbl
            // 
            this.aboutLbl.AutoSize = true;
            this.aboutLbl.Location = new System.Drawing.Point(259, 246);
            this.aboutLbl.Name = "aboutLbl";
            this.aboutLbl.Size = new System.Drawing.Size(13, 13);
            this.aboutLbl.TabIndex = 4;
            this.aboutLbl.Text = "v";
            // 
            // websiteLinkLbl
            // 
            this.websiteLinkLbl.AutoSize = true;
            this.websiteLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.websiteLinkLbl.LinkColor = System.Drawing.Color.Black;
            this.websiteLinkLbl.Location = new System.Drawing.Point(6, 246);
            this.websiteLinkLbl.Name = "websiteLinkLbl";
            this.websiteLinkLbl.Size = new System.Drawing.Size(107, 13);
            this.websiteLinkLbl.TabIndex = 5;
            this.websiteLinkLbl.TabStop = true;
            this.websiteLinkLbl.Text = "http://houseshare.se";
            this.websiteLinkLbl.VisitedLinkColor = System.Drawing.Color.Black;
            this.websiteLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websiteLinkLbl_LinkClicked);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AntonysApps.HouseShare.Properties.Resources.house;
            this.ClientSize = new System.Drawing.Size(296, 268);
            this.Controls.Add(this.websiteLinkLbl);
            this.Controls.Add(this.aboutLbl);
            this.Controls.Add(this.openHouseButt);
            this.Controls.Add(this.housesCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.Text = "HouseShare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox housesCB;
        private System.Windows.Forms.Button openHouseButt;
        private System.Windows.Forms.Label aboutLbl;
        private System.Windows.Forms.LinkLabel websiteLinkLbl;
    }
}

