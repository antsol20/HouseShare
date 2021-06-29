namespace AntonysApps.HouseShare
{
    partial class renameDialog
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
            this.okButt = new System.Windows.Forms.Button();
            this.cancelButt = new System.Windows.Forms.Button();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButt
            // 
            this.okButt.AutoSize = true;
            this.okButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButt.Location = new System.Drawing.Point(146, 25);
            this.okButt.Name = "okButt";
            this.okButt.Size = new System.Drawing.Size(32, 23);
            this.okButt.TabIndex = 0;
            this.okButt.Text = "OK";
            this.okButt.UseVisualStyleBackColor = true;
            this.okButt.Click += new System.EventHandler(this.okButt_Click);
            // 
            // cancelButt
            // 
            this.cancelButt.AutoSize = true;
            this.cancelButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButt.Location = new System.Drawing.Point(179, 25);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(50, 23);
            this.cancelButt.TabIndex = 1;
            this.cancelButt.Text = "Cancel";
            this.cancelButt.UseVisualStyleBackColor = true;
            this.cancelButt.Click += new System.EventHandler(this.cancelButt_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(12, 25);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(128, 20);
            this.nameTB.TabIndex = 3;
            // 
            // renameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 73);
            this.ControlBox = false;
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.cancelButt);
            this.Controls.Add(this.okButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "renameDialog";
            this.Text = "Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButt;
        private System.Windows.Forms.Button cancelButt;
        private System.Windows.Forms.TextBox nameTB;
    }
}