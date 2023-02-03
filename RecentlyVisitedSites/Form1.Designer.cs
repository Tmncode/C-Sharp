namespace RecentlyVisitedSites
{
    partial class RecentlyVisitedSites
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
            this.lnkOne = new System.Windows.Forms.LinkLabel();
            this.lnkTwo = new System.Windows.Forms.LinkLabel();
            this.lnkThree = new System.Windows.Forms.LinkLabel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkOne
            // 
            this.lnkOne.AutoSize = true;
            this.lnkOne.Location = new System.Drawing.Point(13, 13);
            this.lnkOne.Name = "lnkOne";
            this.lnkOne.Size = new System.Drawing.Size(41, 13);
            this.lnkOne.TabIndex = 0;
            this.lnkOne.TabStop = true;
            this.lnkOne.Text = "Google";
            this.lnkOne.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOne_LinkClicked);
            this.lnkOne.MouseHover += new System.EventHandler(this.lnkOne_MouseHover);
            // 
            // lnkTwo
            // 
            this.lnkTwo.AutoSize = true;
            this.lnkTwo.Location = new System.Drawing.Point(13, 30);
            this.lnkTwo.Name = "lnkTwo";
            this.lnkTwo.Size = new System.Drawing.Size(54, 13);
            this.lnkTwo.TabIndex = 1;
            this.lnkTwo.TabStop = true;
            this.lnkTwo.Text = "Wikipedia";
            this.lnkTwo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTwo_LinkClicked);
            this.lnkTwo.MouseHover += new System.EventHandler(this.lnkTwo_MouseHover);
            // 
            // lnkThree
            // 
            this.lnkThree.AutoSize = true;
            this.lnkThree.Location = new System.Drawing.Point(13, 47);
            this.lnkThree.Name = "lnkThree";
            this.lnkThree.Size = new System.Drawing.Size(50, 13);
            this.lnkThree.TabIndex = 2;
            this.lnkThree.TabStop = true;
            this.lnkThree.Text = "Microsoft";
            this.lnkThree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkThree_LinkClicked);
            this.lnkThree.MouseHover += new System.EventHandler(this.lnkThree_MouseHover);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(124, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 3;
            // 
            // RecentlyVisitedSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 241);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lnkThree);
            this.Controls.Add(this.lnkTwo);
            this.Controls.Add(this.lnkOne);
            this.Name = "RecentlyVisitedSites";
            this.Text = "RecentlyVisitedSites";
            this.Load += new System.EventHandler(this.RecentlyVisitedSites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkOne;
        private System.Windows.Forms.LinkLabel lnkTwo;
        private System.Windows.Forms.LinkLabel lnkThree;
        private System.Windows.Forms.Label lblInfo;
    }
}

